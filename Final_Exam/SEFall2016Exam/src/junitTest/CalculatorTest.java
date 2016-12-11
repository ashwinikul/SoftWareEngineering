package junitTest;

import static org.junit.Assert.*;

import org.junit.Test;

public class CalculatorTest {

	Calculator cal= new Calculator();
	int Value;
	@Test
	public void TestforNegativeResult1() {

		Value =cal.CalculatorFromReversePolish("1 2 - 4 5 + *");
		assertEquals(-9,Value);
		
	}

	
	@Test
	public void TestforNegativeResult2() {
		
		Value =cal.CalculatorFromReversePolish("3 9 - 2 1 + /");
		assertEquals(-2,Value);


	}
	
	
	@Test
	public void TestforFloatResult() {
		// as program having integer values need to check for calculated values resulted into float 
		//for 9 3 - 6 1 - / =6/5=1.2 as result is integer so it should be 1 
		Value =cal.CalculatorFromReversePolish("9 3 - 6 1 - /");
		assertEquals(1,Value);

	}
	
	public void TestforFloatValues() {
		//try
		//{
		Value =cal.CalculatorFromReversePolish("1.4 2 + 4 5 + *");
		assertEquals(27,Value);
		
	}
	
	@Test
	public void TestforNoramlValues() {
		
		Value =cal.CalculatorFromReversePolish("9 3 - 2 1 + /");
		assertEquals(2,Value);

	}
	
	@Test
	public void testForZeroNumerator() {
		
		Value =cal.CalculatorFromReversePolish("9 9 - 2 1 + /");
		assertEquals(0,Value);
		
	}
    
	
	
	@Test
	public void TestForNegativeValues() {
		
		Value =cal.CalculatorFromReversePolish("9 9 + -1 1 - /");
		assertEquals(-9,Value);
		
	}
	
	
	@Test
	// stack has DEFAULT_INITIAL_CAPACITY=16, and it increase if more than16 items pushed to stack
	public void TestFor16items() {

		Value =cal.CalculatorFromReversePolish("1 2 - 4 5 + * 1 2 - 4 5 + * + 4 5 + -");
		assertEquals(-27,Value);
		
	}

	@Test

    public void testMultiplyByZero() {
    	Value =cal.CalculatorFromReversePolish("0 7 *");
    	assertEquals(0,Value);
	}
    
	@Test
    (expected=java.lang.ArithmeticException.class)
    public void testDivideByZero() {
    	Value =cal.CalculatorFromReversePolish("2 1 + 9 9 - /");
	}
		


}