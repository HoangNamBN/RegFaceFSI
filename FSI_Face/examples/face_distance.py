import face_recognition

# Load some images to compare against
known_obama_image = face_recognition.load_image_file("obama.jpg")
known_biden_image = face_recognition.load_image_file("biden.jpg")

# Get the face encodings for the known images
obama_face_encoding = face_recognition.face_encodings(known_obama_image)[0]
biden_face_encoding = face_recognition.face_encodings(known_biden_image)[0]

known_encodings = [
    obama_face_encoding,
    biden_face_encoding
]
# Load a test image and get encondings for it
image_to_test = face_recognition.load_image_file("obama2.jpg")
image_to_test_encoding = face_recognition.face_encodings(image_to_test)[0]

# See how far apart the test image is from the known faces
face_distances = face_recognition.face_distance(known_encodings, image_to_test_encoding)

for i, face_distance in enumerate(face_distances):
    print("Hinh anh co khoang cach la {:.2} so voi hinh anh da biet".format(face_distance, i))
    print("- Voi khoang cach euclide la 0.6, hinh anh thu nghiem khop voi hinh anh da biet ? {}".format(face_distance < 0.6))
    print("- Voi khoang cach euclide la 0.5, hinh anh thu nghiem khop voi hinh anh da biet ? {}".format(face_distance < 0.5))
