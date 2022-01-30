/*The selection sort algorithm sorts an array by repeatedly finding the minimum element (considering ascending order) from unsorted part and putting it at the beginning. The algorithm maintains two subarrays in a given array.
1) The subarray which is already sorted. 
2) Remaining subarray which is unsorted.
In every iteration of selection sort, the minimum element (considering ascending order) from the unsorted subarray is picked and moved to the sorted subarray. */
/*სელექშენ სორტ ალგორითმი მასივს ალაგებს ყველაზე მცირე ელემენტის პოვნის საშუალებით (თუ ზრდადობით გვინდა დალაგება) და სვავს დასაწყისში. ალგორითმის მოცემულ მასივში არის ორი სუბ-მასივი.
1) სუბ-მასივი რომელიც უკვე დალაგებულია.
2) დარჩენილი მასივი, რომელიც ჯერ კიდე დასალაგებელია.
ყოველ დატრიალებაზე უმცირესი ელემენტი ირჩევა დასალაგებელი მასივიდან და თავსდება დალაგებული მასივის თავში */


int []arr = {55,35,15,25,5}; // მოცემული მასივი, რომელიც უნდა დავალაგოთ

Console.Write("Unsorted Array: ");
printArray(arr);// ჯერ ვბეჭდავთ დაულაგებელ, პირვანდელ მასივს
//////////////////////////////////////////////////////////
sortArray(arr);// ვალაგებთ
Console.Write("\nSelection Sorted Array: "); // და საბოლოდ ვბეჭდავ სელექშელ სორტით დალაგებულ მასივს
printArray(arr);


Console.ReadKey();
static void sortArray(int[] givenArray) // ხოლო ამის გამოძახებით ვალაგებთ ერეის Selection Sort ის ალგორითმით
{
    

    for(int i = 0; i < givenArray.Length-1; i++) // ვიღებთ მასივს - 1 იტერაციის მქონე for ლუპს 
    {
        int minNumIndex = i; // პირობითად ვიღებთ რომ მინიმალური რიცხვის ინდექსი არის i, რათა შევამოწმოთ მასზე პატარა რიცხვები
        for(int j = i+1; j < givenArray.Length; j++) // ვამოწმებთ მასივში ყველა i - ს შემდეგ მყოფ რიცვს
        {
            if(givenArray[j] < givenArray[minNumIndex]) // თუ რომელიმე i - ზე პატარაა ვანიჭებთ მინიმუმ ინდექსს
            {
                minNumIndex = j;
            }
           
        }
        int temp = givenArray[minNumIndex]; // და საბოლოოდ i სა და მინიმალური რიცხვის ინდექს ვუცვლით ადგილებს
        givenArray[minNumIndex] = givenArray[i];
        givenArray[i] = temp;

    }

}



static void printArray(int[] givenArray) // ამის გამოძახებით ვბეჭდავთ ნებისმიერ მასივს
{
    for(int i=0; i<givenArray.Length; i++)
    {

        Console.Write(givenArray[i] + "|");
    }
}