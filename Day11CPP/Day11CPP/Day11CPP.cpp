#include <iostream>
using namespace std;//not considered good programming

int main()
{
    //std -- namespace
    //:: -- scope resolution operator
    //      same as System.
    //cout -- console output stream. Console.Write
    //<< -- insertion operator. inserting text into the stream
    cout << "Hello Gotham!\n" << 5 << "\nBatman rules!\n";
    
    cout << sizeof(char) << "(bytes)\n";

    char name[] = "Batman";//adds a '\0' (null terminator)
    char meh[] = { 'A','q','u','a','m','a','n' };//does not add \0
    cout << name << "\n" << meh << "\n";

    int nums[] = { 1,2,3,4,5 };
    for (size_t i = 0; i < 5; i++)
    {
        cout << nums[i] << " ";
    }
    cout << "\n";

    srand((unsigned)time(NULL));
    cout << RAND_MAX << "\n";
    int rando = rand();//0-RAND_MAX 
    cout << rando << "\n";
    int grade = rand() % 101;//0-100
    cout << grade << "\n";
}