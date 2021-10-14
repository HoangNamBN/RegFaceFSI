import face_recognition
import os
from PIL import Image, ImageDraw
import cv2
from sklearn.model_selection import train_test_split
import math
from sklearn import neighbors
import os.path
import pickle
import time
from face_recognition.face_recognition_cli import image_files_in_folder
ALLOWED_EXTENSIONS = {'png', 'jpg', 'jpeg','PNG'}
def image_data(datafolder, path_train, path_test):
    X = []
    Y = []
    print ("Is dividing the train test ...")
    for folder in os.listdir(datafolder):
        curr_path = os.path.join(datafolder, folder)
        for file in os.listdir(curr_path):
            curr_file = os.path.join(curr_path, file)
            image = cv2.imread(curr_file)
            X.append(image)
            Y.append(folder)
    X_train, X_test, Y_train, Y_test = train_test_split(X, Y, test_size=0.20, random_state= 42)
    if not os.path.exists(path_train):
        os.mkdir(path_train)
    if not os.path.exists(path_test):
        os.mkdir(path_test)
    print ("Number of photo train:",len(X_train), "and Number of photo test:",len(X_test))
    return X_train, X_test, Y_train, Y_test, path_train, path_test, datafolder

def SaveImage(X_train, X_test, Y_train, Y_test, path_train, path_test):
    for i in range(len(X_train)):
        if not os.path.exists(path_train + "/" + Y_train[i]):
            os.mkdir(path_train + "/" + Y_train[i])
        pathout_train = path_train + "/" + Y_train[i]
        cv2.imwrite(pathout_train + "/" +  str(i) + ".jpg", X_train[i])
    for i in range(len(X_test)):
        cv2.imwrite(path_test + "/" + Y_test[i] + "_" + str(i) + ".jpg", X_test[i])

def ImageFileCount(path_train, path_test):
    for path in os.listdir(path_train):
        curr_path = os.path.join(path_train, path)
        CountImage = 0
        for file in os.listdir(curr_path):
            os.path.join(curr_path, file)
            CountImage += 1
        print ("folder", curr_path,"la:", CountImage,"image to train")
    list_name = []
    for image_file in os.listdir(path_test):
        str(image_file.split("_")[0])
        list_name.append(str(image_file.split("_")[0]))
    set_name = set(list_name)
    sorted(set_name)
    for cout_name in set_name:
        result = 0
        for name in list_name:
            if name == cout_name:
                result +=1
        print ("folder",cout_name,"using",result,"image to test")

def CheckMaxMin(path_train):
    NumberFile = path_train + "/" + os.listdir(path_train)[0]
    filemin = len(os.listdir(NumberFile))
    filemax = len(os.listdir(NumberFile))
    foldermin = os.listdir(path_train)[0]
    foldermax = os.listdir(path_train)[0]
    for folder in os.listdir(path_train):
        person = path_train + "/" + folder
        if len(os.listdir(person)) < filemin:
            filemin = len(os.listdir(person))
            foldermin = folder
        if len(os.listdir(person)) > filemax:
            filemax = len(os.listdir(person))
            foldermax = folder
    print ('The least picture folder is the folder', foldermin, 'with image number is:', filemin)
    print ("The folder with the most pictures is the folder", foldermax , 'with image number is:', filemax)

def train(path_train, model_save_path=None, n_neighbors=None, knn_algo='ball_tree', verbose=False):
    X = []
    y = []
    for class_dir in os.listdir(path_train):
        if not os.path.isdir(os.path.join(path_train, class_dir)):
            continue
        for img_path in image_files_in_folder(os.path.join(path_train, class_dir)):
            image = face_recognition.load_image_file(img_path)
            face_bounding_boxes = face_recognition.face_locations(image)
            if len(face_bounding_boxes) != 1:
                if verbose:
                    print("Image {} not suitable for training: {}".format(img_path, "Didn't find a face" if len(face_bounding_boxes) < 1 else "Found more than one face"))
            else:
                X.append(face_recognition.face_encodings(image, known_face_locations=face_bounding_boxes)[0])
                y.append(class_dir)
    if n_neighbors is None:
        n_neighbors = int(round(math.sqrt(len(X))))
        if verbose:
            print("Chose n_neighbors automatically:", n_neighbors)
    knn_clf = neighbors.KNeighborsClassifier(n_neighbors=n_neighbors, algorithm=knn_algo, weights='distance')
    knn_clf.fit(X, y)
    if model_save_path is not None:
        with open(model_save_path, 'wb') as f:
            pickle.dump(knn_clf, f)
    return knn_clf

count = 0
timer = 0
def predict(X_img_path, knn_clf=None, model_path=None, distance_threshold=0.75):
    global count
    global timer
    if not os.path.isfile(X_img_path) or os.path.splitext(X_img_path)[1][1:] not in ALLOWED_EXTENSIONS:
        raise Exception("Invalid image path: {}".format(X_img_path))
    if knn_clf is None and model_path is None:
        raise Exception("Must supply knn classifier either thourgh knn_clf or model_path")
    if knn_clf is None:
        with open(model_path, 'rb') as f:
            knn_clf = pickle.load(f)
    X_img = face_recognition.load_image_file(X_img_path)
    start2 = time.time()
    X_face_locations = face_recognition.face_locations(X_img)
    end2 = time.time()
    timer = timer + float(str(end2-start2))
    if len(X_face_locations) == 0:
        return []
    count = count + len(X_face_locations)
    faces_encodings = face_recognition.face_encodings(X_img, known_face_locations=X_face_locations)
    closest_distances = knn_clf.kneighbors(faces_encodings, n_neighbors=1)
    are_matches = [closest_distances[0][i][0] <= distance_threshold for i in range(len(X_face_locations))]
    return [(pred, loc) if rec else ("unknown", loc) for pred, loc, rec in zip(knn_clf.predict(faces_encodings), X_face_locations, are_matches)]

def show_prediction_labels_on_image(img_path, predictions, path_out):
    pil_image = Image.open(img_path).convert("RGB")
    draw = ImageDraw.Draw(pil_image)
    nameout = ""
    for name, (top, right, bottom, left) in predictions:
        draw.rectangle(((left, top), (right, bottom)), outline=(255, 0, 0))
        name = name.encode("UTF-8")
        text_width, text_height = draw.textsize(name)
        draw.rectangle(((left, bottom - text_height - 10), (right, bottom)), fill=(255, 0, 0), outline=(255, 0, 0))
        draw.text((left + 6, bottom - text_height - 5), name, fill=(255, 255, 255, 255))
        nameout = str(name).replace("b'", "").replace("'", "")
    del draw
    pil_image.save(path_out)
    return nameout

if __name__ == "__main__":
    datafolder = "DataSetFace"
    path_train = "Train_Knn"
    path_test = "Test_Knn"
    if not os.path.exists(path_train):
        os.mkdir(path_train)
    if not os.path.exists(path_test):
        os.mkdir(path_test)
    if len(os.listdir(path_train)) != 0 or len(os.listdir(path_test)) != 0:
        print ("Da chia tap train test")
    else:
        X_train, X_test, Y_train, Y_test, path_train, path_test, datafolder = image_data(datafolder, path_train, path_test)
        SaveImage(X_train, X_test, Y_train, Y_test, path_train, path_test)
        ImageFileCount(path_train, path_test)
        CheckMaxMin(path_train)
    print("Training KNN classifier...")
    start = time.time()
    classifier = train(path_train, model_save_path="trained_knn_model.clf", n_neighbors=2)
    end = time.time()
    print ("Time to train a photo is: ", (float(str(end - start)) / len(os.listdir(path_train))))
    print("Training complete!")
    OutImage = "OutPut_knn"
    if not os.path.exists(OutImage):
        os.mkdir(OutImage)
    count1 = 0
    for image_file in os.listdir(path_test):
        full_file_path = os.path.join(path_test, image_file)
        predictions = predict(full_file_path, model_path="trained_knn_model.clf")
        path_out = OutImage + "/" + image_file
        name = show_prediction_labels_on_image(full_file_path, predictions, path_out)
        if str(name) == str(image_file.split("_")[0]):
            count1+=1
    print("The face number has been detected: ", count)
    print("Detect accuracy in test set: ", str(count * 100 / len(os.listdir(path_test))))
    print("The time to detect an image is: ", timer / count)
    print("Number of correctly identified images: ", (count1))
    print("Detection accuracy for the detected set: ", str(count1 * 100 / count))