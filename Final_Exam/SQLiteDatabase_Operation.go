package main

import (
	"database/sql"
	_ "github.com/mattn/go-sqlite3"
)
import (
        "fmt"
        "log"
)

// for provided data store
type Courses struct {
Semester string
Course string
}

// to connect to DB
func ConnectDB() (*sql.DB) {
	db, error := sql.Open("sqlite3", "/home/ashwini/P4")
	if error != nil { panic(error) }
	if db == nil { panic("db nil") }
	
	return db
}

// to execute SQL query
func ExecQuery(db *sql.DB, query string) (string) {
	DCL, err := db.Exec("Begin Transaction;")
	DCL, err = db.Exec(query)

	if err != nil {
					log.Fatal(err)
					return "Fail"
				}

	db.Exec("Commit;")
	fmt.Println(" Function Executed : ",DCL)	
	return "Success"

}


func main() {

var query string
var flag string
var data =[]Courses{{"Fall 2016","Software Engineering"},{"Spring 2016","Software Project Management"}}

db := ConnectDB()

//drop if exists
query="drop table if exists DIM_COURSES;"	

flag = ExecQuery(db, query )

//Create table
query = "CREATE TABLE DIM_COURSES (  Semester varchar(20) NOT NULL,  Course varchar(100) NOT NULL)"

flag = ExecQuery(db, query )

//insert data into table
for _, record := range data {

query = "INSERT INTO DIM_COURSES VALUES ('"+record.Semester+"','"+record.Course+"')"

flag = ExecQuery(db, query )

}


//data display
rows, err := db.Query("select Semester, Course from DIM_COURSES;",)

fmt.Println("******************** Database Read ************************")							

fmt.Println("Semester \t Courses")				   						
for rows.Next() {
rec := new(Courses)

err = rows.Scan(&rec.Semester , &rec.Course )
	if err != nil {
					log.Fatal(err)
					flag = "fail"
				   }
fmt.Println("" + rec.Semester + "\t" + rec.Course )				   
}						


if flag == "fail" {

fmt.Println(" Operaition failed" )	

} 

defer db.Close()

}