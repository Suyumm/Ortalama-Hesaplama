import urllib.request
import os
current_Folder=os.getcwd()
images_folder = current_Folder+os.sep+"images"

if not os.path.isdir(images_folder):
    os.mkdir(images_folder)
    print("klasör oluştu")
    n=int(input("Foto adedi:"))

    url="https://source.unsplash.com/random"
   
   for i i range(1,n+1):
       filename=images_folder + os.sep + f"image{i}" + ".png"
       urllib.request.urlretrieve(url,filename)