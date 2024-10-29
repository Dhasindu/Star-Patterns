
//-------------------------------------------------------
//======1. This creates an inverted triangle pattern========
//-------------------------------------------------------

for (int i = 1; i <= 5; i++)  // Loop through each row, from 1 to 5
{
    for (int j = 5; j >= i; j--)  // Print decreasing stars from 5 down to the row number (i)
    {
        Console.Write(" * ");
    }
    Console.WriteLine();  // Move to the next line after each row
}


Console.WriteLine("\n\n");  // Print two blank lines as a separator

//------------------------------------------------------
//======2. This creates a right triangle pattern==========
//------------------------------------------------------

for (int i = 1; i <= 5; i++)  // Loop through each row, from 1 to 5
{
    for (int j = 1; j <= i; j++)  // Print stars equal to the row number (i)
    {
        Console.Write(" * ");
    }
    Console.WriteLine();  // Move to the next line after each row
}



 


//------------------------------------------------------
//======3. This creates a Right-Aligned Triangle Pattern===
//------------------------------------------------------

int i, j;

for (i = 1; i <= 5; i++)  // Loop through each row, from 1 to 5
{
    for (j = 5; j > i; j--)  // Print spaces to align stars to the right
    {
        Console.Write(" ");
    }
    for (j = 1; j <= i; j++)  // Print stars equal to the row number (i)
    {
        Console.Write("*");
    }

    Console.WriteLine(" ");  // Move to the next line after each row
}




//------------------------------------------------------
//======4. This creates a Center-Aligned Triangle Pattern==
//------------------------------------------------------

int i, j;
for (i = 1; i <= 5; i++)  // Loop through each row, from 1 to 5
{
    for (j = 5; j > i; j--)  // Print spaces to center-align the triangle
    {
        Console.Write(" ");
    }
    for (j = 1; j <= 2 * i - 1; j++)  // Print stars; odd numbers of stars to form a triangle
    {
        Console.Write("*");
    }
    Console.WriteLine();  // Move to the next line after each row
}



//------------------------------------------------------
//======5. This creates a Symmetrical Triangle Pattern==
//------------------------------------------------------

int i, j;

for (i = 1; i <= 5; i++)  // Loop through each row, from 1 to 5
{

    //PART 01
    // Part to add spaces for centering the stars
    for (j = 5; j > i; j--)
    {
        Console.Write(" ");
    }

    // Part 1: Print stars up to the row number (i)
    for (j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    // Part 2: Print additional stars to complete the symmetrical shape
    for (j = 1; j < i; j++)
    {
        Console.Write("*");
    }
    // Part to add spaces for centering the stars
    for (j = 5; j > i; j--)
    {
        Console.Write(" ");
    }

    //PART 02
    // Part to add spaces for centering the stars
    for (j = 5; j > i; j--)
    {
        Console.Write(" ");
    }
    // Part 1: Print stars up to the row number (i)
    for (j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    // Part 1: Print stars up to the row number (i)
    for (j = 1; j < i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();  // Move to the next line after each row
}


//------------------------------------------------------
//======6. This creates a Diamond Pattern==
//------------------------------------------------------


int i, j;

// Upper part of the diamond (pyramid shape)
for (i = 1; i <= 5; i++)  // Loop for each row in the upper half
{
    // Print spaces to center-align the stars
    for (j = 5; j > i; j--)
    {
        Console.Write(" ");
    }

    // Print the left half of the stars
    for (j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    // Print the right half of the stars
    for (j = 1; j < i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();  // Move to the next line after each row
}

// Lower part of the diamond (inverted pyramid shape)
for (i = 1; i <= 4; i++)  // Loop for each row in the lower half
{
    // Print spaces to center-align the stars
    for (j = 1; j <= i; j++)
    {
        Console.Write(" ");
    }

    // Print the left half of the stars
    for (j = 4; j >= i; j--)
    {
        Console.Write("*");
    }

    // Print the right half of the stars
    for (j = 4; j > i; j--)
    {
        Console.Write("*");
    }

    Console.WriteLine(" ");  // Move to the next line after each row
}
