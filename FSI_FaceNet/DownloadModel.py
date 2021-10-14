from keras.models import load_model
model = load_model("Models/facenet_keras.h5",compile=False)
print(model.inputs)
print(model.outputs)