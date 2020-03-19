
/**
 * Write a description of class heater here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Heater
{
    // instance variables - replace the example below with your own
    private double temperature = 15;
    private double max;
    private double min;
    private double increment;
   

    /**
     * Constructor for objects of class heater
     */
    public Heater(double maxTemp, double minTemp)
    {
       max = maxTemp;
       min = minTemp;
       increment = 5;
    }
    
    
    
    public void warmer()
    { if (temperature < max)
      {
          temperature = temperature + increment;      
      }
      else 
      {  
            System.out.println("The temp is already maximum");
      }
    }
    
    public void cooler()
    {   if (temperature > min)
        
        temperature = temperature - 5;
        
        else
        {
        System.out.println("the temperature is already minimum");
       
        }
    }
    
    public double temperature()
    {
        return temperature;
    }
    
    public double setIncrement()
    { 
      return temperature = 15;
    }
    
    
    
   

    /**
     * An example of a method - replace this comment with your own
     * 
     * @param  y   a sample parameter for a method
     * @return     the sum of x and y 
     */
  
}
