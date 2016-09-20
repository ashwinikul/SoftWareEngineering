package main

import (

  "os"

)

func check(e error) {
    if e != nil {
        panic(e)
    }
}

func main() {

names := []string{"Software Engineering", "Database System", "Internet Of Things" }

   f, err := os.Create("D:\\HW3_go.html")
    check(err)
   f.WriteString("<!DOCTYPE html><html><head><title>Course Details</title></head><body><table  border=\"1\"><tr><th><B>Semester</B></th><th><B>Course</B></th></tr>")
   for i:=0; i<3; i++ {
   f.WriteString("<tr><td>Fall 2016</td><td>")
   f.Write([]byte(names[i]))
   f.WriteString("</td></tr>")
  }
   f.WriteString("</table></body></html>")


}