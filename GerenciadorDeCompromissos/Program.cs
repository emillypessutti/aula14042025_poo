using ConsoleApp.Modelos;

Compromisso compromisso = new();

Console.WriteLine("Vamos registrar um compromisso");

Console.Write("Digite a data do compromisso (dd/MM/aaaa): ");


while (true) {
    try {
        compromisso.Data = Console.ReadLine();
        break;
    } catch (Exception e) {
        Console.Write($"Erro: {e.Message}\nDigite uma nova data: ");
    }
}

Console.Write("Digite a hora do compromisso (HH:mm): ");
var horaDigitada = Console.ReadLine();

TimeSpan horaCompromisso;

while(!TimeSpan.TryParse(horaDigitada, out horaCompromisso) || 
    (horaCompromisso < TimeSpan.FromHours(8) || horaCompromisso > TimeSpan.FromHours(18))) {
    
    Console.WriteLine("HORÁRIO INVÁLIDO OU FORA DO INTERVALO PERMITIDO! (deve ser entre 8h e 18h)\nDigite a hora do compromisso (HH:mm): ");
    horaDigitada = Console.ReadLine();
}


