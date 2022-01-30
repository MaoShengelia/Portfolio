/* Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in wrong order. */
/* ბაბლ სორტი არის ყველაზე მარტივი სორტინგის ალგორითმი, რომელიც მუშაობს მიმდებარე ელემენტების იმ შემთხვევაში გაცვლით თუ ისინი არასწორად არიან დალაგებულნი */




int[] arr = { 55, 35, 15, 25, 5 }; // მოცემული მასივი, რომელიც უნდა დავალაგოთ

Console.Write("Unsorted Array: ");
printArray(arr);// ჯერ ვბეჭდავთ დაულაგებელ, პირვანდელ მასივს

//////////////////////////////////////////////////////////
///
sortArray(arr);// ვალაგებთ
Console.Write("\nSelection Sorted Array: "); // და საბოლოდ ვბეჭდავ სელექშელ სორტით დალაგებულ მასივს
printArray(arr);


Console.ReadKey();
static void sortArray(int[] givenArray) // ხოლო ამის გამოძახებით ვალაგებთ ერეის Selection Sort ის ალგორითმით
{


    for (int i = 0; i < givenArray.Length - 1; i++) // ვიღებთ მასივს - 1 იტერაციის მქონე for ლუპს 
    {
        for (int j = 0; j < givenArray.Length - 1; j++)  // იგივე რაოდენობის მქონე იტერაციის მეორე for ლუპს ვატრიალებთ
        {
            if (givenArray[j] > givenArray[j + 1]) // და იმ შემთხვევაში ვუცვლით ადგილებს, თუ მასივში მყოფი ელემენტი მის შემდეგ ელემენტზე დიდია.
            {
                var temp = givenArray[j];
                givenArray[j] = givenArray[j + 1];
                givenArray[j + 1] = temp;
            }
        }
    }

}



static void printArray(int[] givenArray) // ამის გამოძახებით ვბეჭდავთ ნებისმიერ მასივს
{
    for (int i = 0; i < givenArray.Length; i++)
    {

        Console.Write(givenArray[i] + "|");
    }
}