import face_recognition
from PIL import Image, ImageDraw
import os.path
import time
import os
import os.path
from sklearn import svm
import numpy as np
import pickle
from face_recognition.face_recognition_cli import image_files_in_folder
from examples.DataProcessing import image_data, SaveImage, CheckMaxMin
ALLOWED_EXTENSIONS = {'png', 'jpg', 'jpeg','PNG'}

def train(path_train,model_save_path=None,verbose=False):
    names = []
    means = []
    for class_dir in os.listdir(path_train):
        encodings = []
        if not os.path.isdir(os.path.join(path_train, class_dir)):
            continue
        for img_path in image_files_in_folder(os.path.join(path_train, class_dir)):
            image = face_recognition.load_image_file(img_path)
            face_bounding_boxes = face_recognition.face_locations(image)
            if len(face_bounding_boxes) != 1:
                if verbose:
                    print("Image {} not suitable for training: {}".format(img_path, "Didn't find a face" if len(face_bounding_boxes) < 1 else "Found more than one face"))
            else:
                face_encodings = face_recognition.face_encodings(image)[0]
                encodings.append(face_encodings)
                names.append(class_dir)
                means.append([np.mean(x, axis=0) for x in zip(*encodings)])
    clf = svm.SVC(gamma='scale')
    clf.fit(means, names)
    if model_save_path is not None:
        with open(model_save_path, 'wb') as f:
            pickle.dump([clf,means,names], f)
    return clf, means, names

CountDetect = 0
timer = 0
def show_prediction_labels_on_image(X_img_path,path_out,means,names,model_save_path=None,clf=None):
    global CountDetect
    global timer
    if not os.path.isfile(X_img_path) or os.path.splitext(X_img_path)[1][1:] not in ALLOWED_EXTENSIONS:
        raise Exception("Invalid image path: {}".format(X_img_path))
    if clf is None and model_save_path is None:
        raise Exception("Must supply knn classifier either thourgh knn_clf or model_path")
    pil_image = Image.open(X_img_path).convert("RGB")
    draw = ImageDraw.Draw(pil_image)
    nameout = ""
    X_img = face_recognition.load_image_file(X_img_path)
    start = time.time()
    X_face_locations = face_recognition.face_locations(X_img)
    end = time.time()
    timer = timer + float(str(end-start))
    if len(X_face_locations) == 0:
        return []
    CountDetect = CountDetect + len(X_face_locations)
    faces_encodings = face_recognition.face_encodings(X_img, X_face_locations)
    for (top, right, bottom, left), face_encoding in zip(X_face_locations, faces_encodings):
        matches = face_recognition.compare_faces(means, face_encoding)
        name = "unknown"
        face_distance = face_recognition.face_distance(means, face_encoding)
        best_match_index = np.argmin(face_distance)
        if matches[best_match_index]:
            name = names[best_match_index]
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
    path_train = "Train_DataSetFace"
    path_test = "Test_DataSetFace"
    model_save_path = "svm_means.clf"
    if not os.path.exists(path_train):
        os.mkdir(path_train)
    if not os.path.exists(path_test):
        os.mkdir(path_test)
    if len(os.listdir(path_train))!=0 or len(os.listdir(path_test))!=0:
        print ("Da chia tap train test")
    else:
        X_train, X_test, Y_train, Y_test, path_train, path_test, datafolder = image_data(datafolder, path_train,path_test)
        SaveImage(X_train, X_test, Y_train, Y_test, path_train, path_test)
        CheckMaxMin(path_train)
    if os.path.isfile(model_save_path):
        with open(model_save_path, 'rb') as f:
            clf, means, names = pickle.load(f)
    else:
        print ("Training SVM Means classifier...")
        start = time.time()
        clf, means, names = train(path_train, model_save_path)
        end = time.time()
        print ("Training complete!")
        print ("Time to train a photo is: ", (float(str(end - start)) / len(os.listdir(path_train))))
    print ("is drawing a box around the face and saving the image in a new folder ...")
    ImageOut = "Out_SetFace_means"
    if not os.path.exists(ImageOut):
        os.mkdir(ImageOut)
    CountName = 0
    for image_file in os.listdir(path_test):
        full_file_path = os.path.join(path_test, image_file)
        path_out = ImageOut + "/" + image_file
        name = show_prediction_labels_on_image(full_file_path,path_out, means, names,model_save_path)
        if str(name) == str(image_file.split("_")[0]):
            CountName += 1
    print ("saved successfully !")
    print ("The face number has been detected: ", CountDetect)
    print ("Detect accuracy in test set: ", str(CountDetect * 100 / len(os.listdir(path_test))))
    print ("The time to detect an image is: ", timer / CountDetect)
    print ("Number of correctly identified images: ", (CountName))
    print ("Detection accuracy for the detected set: ", str(CountName * 100 / CountDetect))