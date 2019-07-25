import os
import shutil
from datetime import datetime
from tkinter import *
from tkinter import filedialog

files_database = []


def getSourcePath():
    text = filedialog.askdirectory(initialdir = os.path.expanduser("~"), title="Select Source Folder")
    SourceEntry.delete(0,END)
    SourceEntry.insert(0,text)

def getDestPath():
    text = filedialog.askdirectory(initialdir = os.path.expanduser("~"), title="Select Destination Folder")
    DestEntry.delete(0,END)
    DestEntry.insert(0,text)

def moveFiles():
    sdir, ddir = SourceEntry.get(), DestEntry.get()
    
    files = [x for x in os.listdir(sdir) if x.endswith(".txt")]
    source_paths = [os.path.join(sdir, x) for x in files]
    destination_paths = [os.path.join(ddir, x) for x in files]
    
    print("Moving .txt files from " + sdir + " to " + ddir + " ...")
    for src, dest in zip(source_paths, destination_paths):
        shutil.move(src, dest)
    
    print('(Filename, Last Modified)')
    files_database = []
    for fn, dest in zip(files, destination_paths):
        mtime = datetime.fromtimestamp(os.path.getmtime(dest)).strftime("%d-%b-%Y %H:%M:%S")
        files_database.append((fn, mtime))
        print(fn + ' -> ' + mtime)
    
top = Tk()
top.geometry("700x150")

SourceLabel = Label(top, text = "Source Folder: ")
SourceEntry = Entry(top, bd=1, width=60)
SourceBrowse = Button(top, text="Browse", command=getSourcePath)

DestLabel = Label(top, text = "Destination Folder: ")
DestEntry = Entry(top, bd=1, width=60)
DestBrowse = Button(top, text="Browse", command=getDestPath)

ExtButton = Button(top, text = "Move TXT Files", command=moveFiles)

SourceLabel.place(x = 10, y = 30)
SourceEntry.place(x = 170, y = 30)
SourceBrowse.place(x = 610, y = 30)

DestLabel.place(x = 10, y = 70)
DestEntry.place(x = 170, y = 70)
DestBrowse.place(x = 610, y = 70)

ExtButton.place(x = 300, y = 110)


top.mainloop()

