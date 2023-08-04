/*
    Regras de negócios que a solução deve atender:

    * Se o usuário for um administrador com um nível maior que 55, exiba a mensagem: 
        Welcome, Super Admin user.
    
    * Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:
        Welcome, Admin user.

    * Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:
        Contact an Admin for access.

    * Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:
        You do not have sufficient privileges.

    * Se o usuário não for um administrador nem um gerente, exiba a mensagem:
        You do not have sufficient privileges.


*/
// string permission = "Admin|Manager";
// int level = 55;


string permission = "Manager";
int level = 10;

if (permission.Contains("Admin")){
    Console.WriteLine($"Welcome,{(level > 55 ? " Super" : "" )} Admin user.");
}
else{
    if (permission.Contains("Manager") && level > 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else{
        Console.WriteLine("You do not have sufficient privileges.");
    }
}