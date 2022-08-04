int count = 0;
int distans = 10000;
int SF1 = 1;
int SF2 = 2;
int Fr = 2;
int DS = 5;
int time = 0;

while(distans>10)
{
    if(Fr==1)
    {
        time = distans/(SF1 + DS);
        Fr = 2;
    } 
    else {
        time = distans/(SF2 + DS);
        Fr = 1;
    }

    distans = distans - (SF1 + SF2) * time;
    count = count + 1;
}
Console.WriteLine(count);


