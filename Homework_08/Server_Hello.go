//By Ashwini Kulkarni
//Program to display Hello application on localhost
package main

import (
    "fmt"
    "net/http"
)

func handler(w http.ResponseWriter, r *http.Request) {
    fmt.Fprintf(w, "<h1><font size=26>Hello ACS560 !</font></h1> %s", r.URL.Path[1:])

}

func main() {
    http.HandleFunc("/", handler)
    http.ListenAndServe(":12000", nil)
}