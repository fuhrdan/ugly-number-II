//*****************************************************************************
//** 264. Ugly Number II  leetcode                                           **
//** this will exceed the time limit, but it's an easy fix to make it work.  **
//*****************************************************************************


int nthUglyNumber(int n) {
    if (n == 1) return 1;

    int current = 1;
    int counted = 1;

    while (counted < n)
    {
        current++;
        int num = current;
        if(num <= 0) return 0;
        while (num % 2 == 0) num /= 2;
        while (num % 3 == 0) num /= 3;
        while (num % 5 == 0) num /= 5;

        if(num == 1)
        {
            counted++;
        }

    }
    return current;
}