
import tkinter
from tkinter import *


class ParentWindow(Frame):
    def __init__ (self, master):
        Frame.__init__(self)

        self.master = master
        self.master.resizable(width=False, height=False)
        self.master.geometry('{}x{}'.format(600, 244))
        self.master.title('Check Files')
        self.master.config(bg='#F0F0F0')

        self.entry = StringVar()
        self.entry = StringVar()


        self.txtFName = Entry(self.master,text=self.entry, font=('Helvetica', 16), fg='black',  bg='white', width = 35)
        self.txtFName.grid(row=1, column= 1, padx=(20,0), pady=(50,0))

        self.txtLName = Entry(self.master,text=self.entry, font=('Helvetica', 16), fg='black', bg='white', width = 35)
        self.txtLName.grid(row= 2, column= 1, padx=(20,0), pady=(15,0))

        self.btnBrowse1 = Button(self.master, text='Browse...', width=15, height=2)
        self.btnBrowse1.grid(row= 1, column= 0, padx=(20,0), pady=(50,0))

        self.btnBrowse2 = Button(self.master, text='Browse...', width=15, height=2)
        self.btnBrowse2.grid(row= 2, column= 0, padx=(20,0), pady=(20,0))

        self.btnCheck_files = Button(self.master, text='Check for files...', width=15, height=3)
        self.btnCheck_files.grid(row= 3, column= 0, padx=(20,0), pady=(20,0))

        self.btnClose_prog = Button(self.master, text='Close Program', width=15, height=3)
        self.btnClose_prog.grid(row= 3, column= 1, padx=(330,0), pady=(20,0))


if __name__ == "__main__":
    root = Tk()
    App = ParentWindow(root)
    root.mainloop()
