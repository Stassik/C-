// Если юзера зовут Сергей, то выведем на экран "Сергей, лучший преподаватель!". Если нет то - "Ааа, это всего лишь (имя юзера)".


// 1. Сделаем запрос имени
Console.Write("Здравствуйте! Пожалуйста, представьтесь: ");
string username = Console.ReadLine();

if(username.ToLower() == "сергей") {
   Console.WriteLine("Сергей, лучший преподаватель!"); 
}
else {
    Console.WriteLine ("Ааа, это всего лишь " + username);
};