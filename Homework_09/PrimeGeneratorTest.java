import junit.framework.*;


public class PrimeGeneratorTest extends TestCase
{
    public void testSingleValue()
    {
        // Passing 0 and 1 value, which are not prime 
    	int[] array1 = PrimeGenerator.generatePrimes(0);
        assertEquals(array1.length,0);
        int[] array2 = PrimeGenerator.generatePrimes(0);
        assertEquals(array2.length,0);
        
        // passing no 2, will return single prime number
        int[] minArray = PrimeGenerator.generatePrimes(2);
        assertEquals(minArray.length, 1);
        assertEquals(minArray[0], 2);
        
     // passing no 3, will return two prime numbers
        int[] threeArray = PrimeGenerator.generatePrimes(3);
        assertEquals(threeArray.length,2);
        assertEquals(threeArray[0], 2);
        assertEquals(threeArray[1], 3);
        
     // passing no 100, will return 25 prime numbers
        int[] centArray = PrimeGenerator.generatePrimes(100);
        assertEquals(centArray.length, 25);
        assertEquals(centArray[24], 97);
    }

    public void testMultiple()
    {
        for (int i = 2; i<5; i++)
        {
        	System.out.println("i=" +i);
            verifyPrimeList(PrimeGenerator.generatePrimes(i));
        }
    }

    private void verifyPrimeList(int[] list)
    {
        for (int i=0; i<list.length; i++)
        {
        	System.out.println("List "+i+ " No "+list[i]);
            verifyPrime(list[i]);
        }
    }

    private void verifyPrime(int n) {
    	if(n!=2)
    	{
        for (int factor=2; factor<n; factor++)
            assertTrue(n%factor != 0);
    	}
    }
}