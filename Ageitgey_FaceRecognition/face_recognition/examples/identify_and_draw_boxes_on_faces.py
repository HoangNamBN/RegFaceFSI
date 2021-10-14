import face_recognition
from PIL import Image, ImageDraw
import numpy as np

# This is an example of running face recognition on a single image
# and drawing a box around each person that was identified.

# Load a sample picture and learn how to recognize it.
obama_image = face_recognition.load_image_file("obama.jpg")
obama_face_encoding = face_recognition.face_encodings(obama_image)[0]

# Load a second sample picture and learn how to recognize it.
biden_image = face_recognition.load_image_file("biden.jpg")
biden_face_encoding = face_recognition.face_encodings(biden_image)[0]

Nam_image = face_recognition.load_image_file("Nam.jpg")
Nam_face_encoding = face_recognition.face_encodings(Nam_image)[0]

# Load a sample picture and learn how to recognize it.
Lan_image = face_recognition.load_image_file("Lan.jpg")
Lan_face_encoding = face_recognition.face_encodings(Lan_image)[0]

# Load a sample picture and learn how to recognize it.
Ngoc_image = face_recognition.load_image_file("Ngoc.jpg")
Ngoc_face_encoding = face_recognition.face_encodings(Ngoc_image)[0]

# Load a sample picture and learn how to recognize it.
Thai_image = face_recognition.load_image_file("Thai.png")
Thai_face_encoding = face_recognition.face_encodings(Thai_image)[0]

# Load a sample picture and learn how to recognize it.
Long_image = face_recognition.load_image_file("long.png")
Long_face_encoding = face_recognition.face_encodings(Long_image)[0]

# Load a sample picture and learn how to recognize it.
Thom_image = face_recognition.load_image_file("Thom.jpg")
Thom_face_encoding = face_recognition.face_encodings(Thom_image)[0]

# Load a second sample picture and learn how to recognize it.
TrungEm_image = face_recognition.load_image_file("./dataset/dataset/TrungTQ/Trung.png")
TrungEm_face_encoding = face_recognition.face_encodings(TrungEm_image)[0]

# Load a second sample picture and learn how to recognize it.
ChiHa_image = face_recognition.load_image_file("./dataset/dataset/HaPT/Ha.png")
ChiHa_face_encoding = face_recognition.face_encodings(ChiHa_image)[0]

# Load a second sample picture and learn how to recognize it.
SepLinh_image = face_recognition.load_image_file("./dataset/dataset/LinhVD/01.jpg")
SepLinh_face_encoding = face_recognition.face_encodings(SepLinh_image)[0]

# Load a second sample picture and learn how to recognize it.
ChiMen_image = face_recognition.load_image_file("./dataset/dataset/MenBT/Men.png")
Men_face_encoding = face_recognition.face_encodings(ChiMen_image)[0]

# Load a second sample picture and learn how to recognize it.
Hariwon_image = face_recognition.load_image_file("Hariwon.jpg")
Hariwon_face_encoding = face_recognition.face_encodings(Hariwon_image)[0]

# Load a second sample picture and learn how to recognize it.
Trung_image = face_recognition.load_image_file("./dataset/dataset/TrungNT/A_Trung.png")
Trung_face_encoding = face_recognition.face_encodings(Trung_image)[0]

# Load a second sample picture and learn how to recognize it.
Duong_image = face_recognition.load_image_file("dataset/dataset/Duong/image.PNG")
Duong_face_encoding = face_recognition.face_encodings(Duong_image)[0]

HaNS_image = face_recognition.load_image_file("dataset/dataset/HaNS/image.PNG")
HaNS_face_encoding = face_recognition.face_encodings(HaNS_image)[0]

Binh_image = face_recognition.load_image_file("dataset/dataset/ChiBinh/Binh.PNG")
Binh_face_encoding = face_recognition.face_encodings(Binh_image)[0]

Hiep_image = face_recognition.load_image_file("dataset/dataset/HiepLM/A_Hiep.png")
Hiep_face_encoding = face_recognition.face_encodings(Hiep_image)[0]

LanNgoc_image = face_recognition.load_image_file("dataset/dataset/NinhDuongLanNgoc/image1.jpg")
LanNgoc_face_encoding = face_recognition.face_encodings(LanNgoc_image)[0]
# Create arrays of known face encodings and their names
known_face_encodings = [
    obama_face_encoding,
    biden_face_encoding,
    Nam_face_encoding,
    Lan_face_encoding,
    Ngoc_face_encoding,
    Thai_face_encoding,
    Long_face_encoding,
    Thom_face_encoding,
    TrungEm_face_encoding,
    ChiHa_face_encoding,
    SepLinh_face_encoding,
    Men_face_encoding,
    Hariwon_face_encoding,
    Trung_face_encoding,
    Duong_face_encoding,
    HaNS_face_encoding,
    Binh_face_encoding,
    Hiep_face_encoding,
    LanNgoc_face_encoding
]
known_face_names = [
    "Barack Obama",
    "Joe Biden",
    "Nam",
    "Lan",
    "Ngoc",
    "Thai",
    "Long",
    "Thom",
    "Trung",
    "Ha",
    "Linh",
    "Men",
    "Hariwon",
    "Anh Trung",
    "Duong",
    "HaNS",
    "Binh",
    "Hiep",
    "LanNgoc"
]

# Load an image with an unknown face

# unknown_image = face_recognition.load_image_file("./dataset/dataset/TrungTQ/Trung.png")
# unknown_image = face_recognition.load_image_file("./dataset/dataset/LinhVD/01.jpg")
# unknown_image = face_recognition.load_image_file("Nam.jpg")
# unknown_image = face_recognition.load_image_file("Long.png")
# unknown_image = face_recognition.load_image_file("Hariwon.jpg")
# unknown_image = face_recognition.load_image_file("Thom.jpg")
# unknown_image = face_recognition.load_image_file("./dataset/dataset/HaPT/Ha.png")
# unknown_image = face_recognition.load_image_file("Thai.png")
# unknown_image = face_recognition.load_image_file("Lan.jpg")
# unknown_image = face_recognition.load_image_file("dataset/Test/image.PNG")
# unknown_image = face_recognition.load_image_file("dataset/dataset/HiepLM/A_Hiep.png")
# unknown_image = face_recognition.load_image_file("dataset/dataset/ChiBinh/Binh.PNG")
# unknown_image = face_recognition.load_image_file("dataset/dataset/HaNS/image.PNG")
unknown_image = face_recognition.load_image_file("dataset/dataset/NinhDuongLanNgoc/image9.jpg")
# unknown_image = face_recognition.load_image_file("dataset/dataset/MenBT/Men.png")
# unknown_image = face_recognition.load_image_file("dataset/dataset/TrungNT/A_Trung.png")
# unknown_image = face_recognition.load_image_file("./obama.jpg")
# unknown_image = face_recognition.load_image_file("./biden.jpg")

# Find all the faces and face encodings in the unknown image
face_locations = face_recognition.face_locations(unknown_image)
face_encodings = face_recognition.face_encodings(unknown_image, face_locations)

# Convert the image to a PIL-format image so that we can draw on top of it with the Pillow library
# See http://pillow.readthedocs.io/ for more about PIL/Pillow
pil_image = Image.fromarray(unknown_image)
# Create a Pillow ImageDraw Draw instance to draw with
draw = ImageDraw.Draw(pil_image)

# Loop through each face found in the unknown image
for (top, right, bottom, left), face_encoding in zip(face_locations, face_encodings):
    # See if the face is a match for the known face(s)
    matches = face_recognition.compare_faces(known_face_encodings, face_encoding)

    name = "Unknown"

    # If a match was found in known_face_encodings, just use the first one.
    # if True in matches:
    #     first_match_index = matches.index(True)
    #     name = known_face_names[first_match_index]

    # Or instead, use the known face with the smallest distance to the new face
    face_distances = face_recognition.face_distance(known_face_encodings, face_encoding)
    best_match_index = np.argmin(face_distances)
    if matches[best_match_index]:
        name = known_face_names[best_match_index]

    # Draw a box around the face using the Pillow module
    draw.rectangle(((left, top), (right, bottom)), outline=(255, 0, 0))

    # Draw a label with a name below the face
    text_width, text_height = draw.textsize(name)
    draw.rectangle(((left, bottom - text_height - 10), (right, bottom)), fill=(255, 0, 0), outline=(255, 0, 0))
    draw.text((left + 6, bottom - text_height - 5), name, fill=(255, 255, 255, 255))


# Remove the drawing library from memory as per the Pillow docs
del draw

# Display the resulting image
pil_image.show()

# You can also save a copy of the new image to disk if you want by uncommenting this line
# pil_image.save("image_with_boxes.jpg")
