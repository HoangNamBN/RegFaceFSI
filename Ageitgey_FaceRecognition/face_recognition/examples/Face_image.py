import face_recognition
import os
from sklearn import svm
import numpy as np
from PIL import Image, ImageDraw
import time


train_dir = os.listdir("Train_Data")
encodings= []
names = []
start = time.time()
for person in train_dir:
    pix = os.listdir("Train_Data"+person)
    for person_image in pix:
        face = face_recognition.load_image_file("Train_Data"+person+"/"+person_image)
        face_bounding_boxes = face_recognition.face_locations(face)
        if len(face_bounding_boxes) == 1:
            face_encodings = face_recognition.face_encodings(face)[0]
            # thêm vào mảng
            encodings.append(face_encodings)
            names.append(person)
        else:
            print(person+"/"+person_image+"was skipped and can't be used for training")


end = time.time()
print("Load Image: " + str(end-start))

clf = svm.SVC(gamma='scale')
clf.fit(encodings, names)


start = time.time()
unknown_image = face_recognition.load_image_file(".Test_Data/AlainDelon_150.jpg")
face_locations = face_recognition.face_locations(unknown_image)
face_encodingss = face_recognition.face_encodings(unknown_image, face_locations)

pil_image = Image.fromarray(unknown_image)
draw = ImageDraw.Draw(pil_image)

for (top, right, bottom, left), face_encoding in zip(face_locations, face_encodingss):
    matches = face_recognition.compare_faces(encodings, face_encoding)
    name ="unknown"

    face_distance = face_recognition.face_distance(encodings, face_encoding)
    best_match_index = np.argmin(face_distance)
    if matches[best_match_index]:
        name = names[best_match_index]

    draw.rectangle(((left, top), (right, bottom)), outline=(255, 0, 0))

    # Draw a label with a name below the face
    text_width, text_height = draw.textsize(name)
    draw.rectangle(((left, bottom - text_height - 10), (right, bottom)), fill=(255, 0, 0), outline=(255, 0, 0))
    draw.text((left + 6, bottom - text_height - 5), name, fill=(255, 255, 255, 255))

# Remove the drawing library from memory as per the Pillow docs
del draw

# Display the resulting image
pil_image.show()
end = time.time()
print("Face_Recognition: " + str(end-start))

