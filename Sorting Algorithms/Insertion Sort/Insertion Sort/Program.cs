/* Insertion sort is a simple sorting algorithm that works similar to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed at the correct position in the sorted part.
Algorithm 
To sort an array of size n in ascending order: 
1: Iterate from arr[1] to arr[n] over the array. 
2: Compare the current element (key) to its predecessor. 
3: If the key element is smaller than its predecessor, compare it to the elements before. Move the greater elements one position up to make space for the swapped element. */
/* ინსერშენ სორტი არის მარტივი ალგორითმი, რომელიც მუშაობს კარტების დალაგების პრინციპით, მასივი იყოფა ორ, დალაგებულ და დაულაგებელ ნაწილად, დაულაგებელი მასივის მნიშვნელობები კი სწორ ადგილას ისმება დალაგებულ მასივში
  რომ დავალაგოთ n ზომის მასივი ზრდადობით ჩვენ დაგვჭირდება:
1: იტერაცია პირველიდან მე - n ე ელემენტამდე
2: იმჟამინდელი ელემენტის მის უკანა ელემენტთან შედარება.
3: თუკი ამჯამინდელი ელემენტი ნაკლებია მის წინამორბედზე, ვადარებთ კიდევ მის უკან მყოფ ელემენტებს, ხოლო შემდეგ წინამორბედებს ვუბიძგებთ ერთით წინ, რათა ადგილი მისცენ გაცვლილ ელემეენტს */




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


    for (int i = 1; i < givenArray.Length ; i++) // მივყვებით პირველ ნაბიჯს და ვიღებთ ლუპს 1 იდან ნ ამდე
    {
      int tempNum = givenArray[i]; //  იტერაციისჟამინდელ რიცხვის მასივის მნიშვნელობას დროებით ვათავსებთ ინტეჯერში
        while (i - 1 >= 0 && givenArray[i - 1] < tempNum) // ხოლო სანამ i არუდრის ნოლს და მასივის წინამორბედი ნაკლებია დროებით რიცხვზე
        {
            givenArray[i] = givenArray[i - 1]; // ერთით უკან ვძრავთ მას
            i--;
        }
        givenArray[i] = tempNum; // ანუ გამოვიდა რომ სწორი ადგილი გამოვუყავით მასივში
    }

}



static void printArray(int[] givenArray) // ამის გამოძახებით ვბეჭდავთ ნებისმიერ მასივს
{
    for (int i = 0; i < givenArray.Length; i++)
    {

        Console.Write(givenArray[i] + "|");
    }
}