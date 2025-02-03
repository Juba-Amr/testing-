int[] tableau = new int[5];
for(int i=0; i<5; i++)
{
    tableau[i]=Convert.ToInt32(Console.ReadLine()); //on initialise le tableau
}  

foreach(int i in tableau){
    Console.WriteLine(i);

}
//un deuxième tableau qui est une copie du premier
int[] tableau2 = (int[])tableau.Clone();
// un tableau vide qu'on va utiliser pour ranger nos elements les plus petits
int[] tableau3 = Array.Empty<int>();


while(tableau2.Length > 0)
{
    int smallestIndex = 0;//index du plus petit element 
    for(int i=1; i < tableau2.Length ; i++) //on cherche justements cet index là
    {
        if(tableau2[i] < tableau2[smallestIndex])
        {
            smallestIndex = i;
        }
    } 

    while(smallestIndex > 0) //on va faire les swipe uns à uns
    {
    
    int temp = tableau2[smallestIndex];

    tableau2[smallestIndex] = tableau2[smallestIndex - 1];
    tableau2[smallestIndex - 1] = temp;
    smallestIndex -- ;
    }

    //on va conserver notre plus petit élèment dans un tableau vide
    tableau3 = tableau3.Append(tableau2[0]).ToArray();
    tableau2 = tableau2[1..];
    

}


foreach(int element in tableau3)
{
    Console.WriteLine(element);
}
Console.WriteLine("Appuyer pour fermer");
Console.ReadLine(); 