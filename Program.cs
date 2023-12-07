Console.Clear();

string [] arrayUser = new string[7] {"123", "qwerty", "dog" , "free1" , "5818q" , "cat" , ":-)"};
string [] arraynew = new string [arrayUser.Length];

CreateArrayThreeEl(arrayUser, arraynew);

void CreateArrayThreeEl (string [] arrayUser, string [] arraynew)
{
    int count = 0;
    for (int i = 0; i < arrayUser.Length; i++)
    {
        if (arrayUser[i].Length <= 3 )
        {
            arraynew[count] = arrayUser[i];
            count++;
        }
    }

}
