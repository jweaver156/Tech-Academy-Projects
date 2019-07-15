import sqlite3

database_name = "acad_sqlite3.db"
conn = sqlite3.connect(database_name)

print( "Opened database successfully");

conn.execute('''CREATE TABLE IF NOT EXISTS FILE 
         (ID INTEGER PRIMARY KEY     AUTOINCREMENT,
         NAME           TEXT    NOT NULL); ''')

print ("Table FILE created successfully");

fileList = {'information.docx', 'Hello.txt', 'myImage.png', \
            'myMovie.mpg', 'World.txt', 'data.pdf', 'myPhoto.jps'}

for file in fileList:
    if file.endswith(".txt"):
        print(file)
        conn.execute("INSERT INTO FILE (NAME) VALUES (:file)", dict(file=file));
        conn.commit()

print("records inserted successfully")
conn.close()
