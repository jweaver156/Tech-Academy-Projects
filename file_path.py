import os

# get present working directory
pwd = os.path.dirname(os.path.realpath(__file__))

# print pwd
print("\nPresent working directory\n", pwd)

# folder name
folder_name = "PythonDrill7"

# get full path to folder
folder_path = os.path.join(pwd, folder_name)

# print path
print("\nPath to folder\n", folder_path)

# iterate over files in the folder
print("\nShowing text files\n")
for file in os.listdir(folder_path):
    # get file name
    filename = os.fsdecode(file)
    # get full file path
    file_path = os.path.join(folder_path, file)
    # use endsWith function
    if filename.endswith(".txt"):
        # {} is a place holder/format specifier
        # s for string, f for float
        # 10 is the width taken by filename
        # 10.3 is the width taken by time
        # .3 shows maximum precision
        print("{:10s} {:10.3f}".
              format(file,
                     os.path.getmtime(file_path)))
