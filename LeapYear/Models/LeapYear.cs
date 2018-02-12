
namespace LeapYear
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else
      {
        return year % 4 == 0;
      }
    }

    public bool IsNumber(string userInput)
    {
      bool isNumeric = int.TryParse(userInput, out int n);
      if (isNumeric == true){
        return true;
      }
      else
      {
        // MessageBox.Show("Please enter a number");
        return false;
      }
    }
  }
}
