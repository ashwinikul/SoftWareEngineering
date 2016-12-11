package Refactoring;
import java.text.DecimalFormat;

//created By Ashwini Kulkarni
//SE Exam Fall 2016 Qus.2 Refactoring 

import java.io.*;

abstract class Shape {
	//public static final int SQUARE			= 1;
	//public static final int CIRCLE			= 2;
	//public static final int RIGHT_TRIANGLE	= 3;
	
	protected int 	shapeType;
	protected double 	size;
	
	
	public Shape(int shapeType, double size) {
		this.shapeType 	= shapeType;
		this.size 		= size;		
	}
	
	abstract double area() ;

}

class Square extends Shape
{
	Square(int shapeType, double size) throws IOException
	{
		super( shapeType,  size);
	}
	double area()
	{
		return size*size;
	}
}

class Circle extends Shape
{
	Circle(int shapeType, double size) throws IOException
	{
		super( shapeType,  size);
	}
	double area()
	{
		return Math.PI * size * size /4.0;
	}
}

class RightTriangle extends Shape
{
	RightTriangle(int shapeType, double size) throws IOException
	{
		super( shapeType,  size);
	}
	double area()
	{
		return size * size /2.0;
	}
}


class SampleTest
{
	public static void main(String args[]) throws IOException
	{
		
		double diameter=8.8;
		double side = 6;
		
		System.out.println("\n***************************\n Shape Type \n 1\t: Square \n 2\t: Circle \n 3\t: RightTriangle \n***************************\n");
		Shape S= new Square(1,side) ;
		System.out.println("Area of Shape type :"+S.shapeType+" of size "+S.size+" is: " +S.area());
		
		S=new Circle(2,diameter);
		System.out.println("Area of Shape type :"+S.shapeType+" of size "+S.size+" is: " +S.area());
		
		S= new RightTriangle(3,side) ;
		System.out.println("Area of Shape type :"+S.shapeType+" of size "+S.size+" is: " +S.area());
	
	}
}
