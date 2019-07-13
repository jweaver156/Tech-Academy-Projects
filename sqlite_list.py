import sqlite3

conn = sqlite3.connect("acad_drill_sqlite3.db")

with conn:
    conn.execute("CREATE TABLE IF NOT EXISTS FILE( \
                    ID INTEGER PRIMARY KEY AUTOINCREMENT, \
                    NAME TEXT NOT NULL)")

fileList = {'Information.docx', 'Hello.txt', 'myImage.png', \
            'myMovie.mpg', 'World.txt', 'Data.pdf', 'myPhoto.jps'}

for file in fileList:
    if file.endswith("txt"):
        conn.execute("INSERT INTO FILE (NAME) VALUES (:file)", \
                     dict(file=file));
        conn.commit()

cursor = conn.execute("SELECT ID, NAME FROM FILE")
for row in cursor:
    print("ID = ", row[0])
    print("NAME = ", row[1])

conn.close()
