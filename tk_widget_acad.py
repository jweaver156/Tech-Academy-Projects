import tkinter as tk
import tkinter.messagebox
from tkinter import *
from tkinter.filedialog import askdirectory


class ParentWindow(Frame):
    def __init__ (self,master):
        Frame.__init__(self)
        
        self.master = master
        self.master.minsize(350,75)
        self.master.maxsize(350,75)
        self.master.title('Get Directory')
        
        self.dirText = Text(self.master, width=35, height=1)
        self.dirText.pack(side=TOP)
        self.dirButton = tkinter.Button(self.master,text="Select Directory",width=12,height=2,command = self.dir_callBack)
        self.dirButton.pack(side=BOTTOM)
    
    
    def dir_callBack(self):
        dirname = askdirectory()
        self.dirText.replace(1.0,END,dirname)


if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
