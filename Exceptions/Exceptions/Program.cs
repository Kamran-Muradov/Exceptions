
using Exceptions;
using Exceptions.Helpers.Exceptions;

void Calculate()
{
    //int a = 5;
    //int b = 0;
    //var result = a / b;
    //Console.WriteLine(result);

    //int[] arr = { 1, 2, 3 };

    //arr[5] = 100;
    bool isCorrectCode = true;
    try
    {
        int[] arr = { 1, 2, 3 };

        //arr[5] = 100;

        int a = 5;
        int b = 0;
        //var result = a / b;
        //Console.WriteLine(result);

        //if (b == 0)
        //{
        //    Console.WriteLine("dont divide to zero");
        //    return;
        //}


    }
    //catch (DivideByZeroException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}
    //catch (IndexOutOfRangeException ex)
    //{
    //    Console.WriteLine(ex.Message);
    //}
    catch (Exception ex)
    {
        isCorrectCode = false;

        //Console.WriteLine(ex.Message);
    }
    finally
    {
        //Console.WriteLine("Finally");

        SendMessage(isCorrectCode);
    }
}

//Calculate();

//Resad resad = new Resad();

void SendMessage(bool isCorrectCode)
{
    if (isCorrectCode)
    {
        Console.WriteLine("Your message successfully");
    }
    else
    {
        Console.WriteLine("Your message failed");
    }
}

string GetById(int? id)
{
    try
    {
        if (id == null)
        {
            //throw new ArgumentNullException(nameof(id), "Salam, menem exception");

            throw new CustomArgumentNullException("Argument cannot be null");
        }

        //ArgumentNullException.ThrowIfNull(id);

        return "Kamran bey";
    }
    catch (Exception ex)
    {
        return ex.Message;
    }

}

var result = GetById(null);

Console.WriteLine(result);