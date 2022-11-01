int distance = 10000;
int count = 0;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_spead = 5;
int friend = 2;
while (distance > 10) ;
{
    if (friend == 1) ;
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
    }
    if (friend == 2) ;
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
    }
    distsnce = distance - (first_friend_speed + second_friend_speed) * time;
    count++;
}
Console.WriteLine(count);