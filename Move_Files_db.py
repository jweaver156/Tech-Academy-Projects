import os
import shutil
from datetime import datetime
from tkinter import *
from tkinter import filedialog
import sqlite3


conn = sqlite3.connect('files.db')
cursor = conn.cursor()

cursor.execute("SELECT count(name) FROM sqlite_master WHERE type='table' AND name='moved_files';")
if cursor.fetchall()[0][0] == 1:
    cursor.execute('DROP TABLE moved_files;')
    conn.commit()

cursor.execute('CREATE TABLE moved_files (id INT AUTO_INCREMENT, file_path TEXT NOT NULL, last_modified DATETIME, PRIMARY KEY (id));')
conn.commit()


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
    
    for fn, dest in zip(source_paths, destination_paths):
        mtime = datetime.fromtimestamp(os.path.getmtime(dest)).strftime("%d-%b-%Y %H:%M:%S")
        cursor.execute("INSERT INTO moved_files (file_path, last_modified) values ('"+ fn +"', '" + mtime + "');")
    conn.commit()
        
    print("Last Modified\t\tFile")
    cursor.execute("SELECT * FROM moved_files;")
    for item in cursor.fetchall():
        print(item[2] + "\t" + item[1])
    
top = Tk()
top.geometry("700x150")

SourceLabel = Label(top, text = "Source Folder: ")
SourceEntry = Entry(top, bd=1, width=60)
SourceBrowse = Button(top, text="Browse...", command=getSourcePath)

DestLabel = Label(top, text = "Destination Folder: ")
DestEntry = Entry(top, bd=1, width=60)
DestBrowse = Button(top, text="Browse...", command=getDestPath)

ExtButton = Button(top, text = "Move TXT Files", command=moveFiles)

SourceLabel.place(x = 10, y = 30)
SourceEntry.place(x = 170, y = 30)
SourceBrowse.place(x = 610, y = 30)

DestLabel.place(x = 10, y = 70)
DestEntry.place(x = 170, y = 70)
DestBrowse.place(x = 610, y = 70)

ExtButton.place(x = 300, y = 110)

top.mainloop()
