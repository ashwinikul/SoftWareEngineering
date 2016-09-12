package main

import (
"fmt"
"math"
)

// calculating square root using Newton's method

func Sqrt(x float64) float64 {

var guess float64  // for guess initialy starts with 1
var res float64  // res for each guess (( (x/z) + z ) / 2)
var q float64 // x/z value
guess = 1.0
res= 0.0
i := int(0)

// when guess and result matches with 4 precision floating point
for math.Abs(guess - res) > 0.00001 {

//exclude for 1st time in loop
if i != 0 {
guess = res
}

q = x
q = q/guess
res = (q+guess)/2
i++

}
 

return guess
}


func main() {

var no float64


fmt.Printf("\n Square Root : using Newton's method\n")

fmt.Printf("\n Enter Number:")

// Accept no from user

fmt.Scanf("%f",&no)

// displaying result with .4 prrecision

fmt.Printf("\n Square Root of %.4f", Sqrt(no))


}