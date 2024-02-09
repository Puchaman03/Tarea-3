
string Finalizador = "";
double aumento = 0;
int TipoEmpleado = 0;
double SalarioOrdinario = 0;
int horasTrabajadas = 0;
int precioPOrhora = 0;
double salarioBruto = 0;
double deduccionCCSS = 0;
double salarioNeto = 0;
int Ej = 0;

do
{
    object[,] Sistema = new object[Ej+1,10];
    Console.WriteLine("******Bienvenido al sistema de salarios de la empresa Akira S.A*****");
    Console.WriteLine("Ingrese la cedula del empleado: ");
    Sistema[Ej, 0] = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre del empleado: ");
    Sistema[Ej, 1] = Console.ReadLine();
    Console.Write("Tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
    TipoEmpleado = int.Parse(Console.ReadLine());
    while (TipoEmpleado > 3 || TipoEmpleado < 1)
    {
        Console.Write("ERROR, escriba el otra vez, Tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
        TipoEmpleado = int.Parse(Console.ReadLine());
    }
    Sistema[Ej, 2] = TipoEmpleado;
    Console.WriteLine("Cantidad de horas trabajadas");
    horasTrabajadas = int.Parse(Console.ReadLine());
    Sistema[Ej, 3] = horasTrabajadas;
    Console.WriteLine("precio por hora");
    precioPOrhora = int.Parse(Console.ReadLine());
    Sistema[Ej,4] = precioPOrhora;

    // Salario ordinario
    SalarioOrdinario = horasTrabajadas * precioPOrhora;
    Sistema[Ej, 5] = SalarioOrdinario;

    // clase de empleado
    switch (TipoEmpleado)
    {
        case 1: // Operario
            aumento = SalarioOrdinario * 0.15;
            break;
        case 2: // Técnico
            aumento = SalarioOrdinario * 0.10;
            break;
        case 3: // Profesional
            aumento = SalarioOrdinario * 0.05;
            break;
    }
    Sistema[Ej, 6] = aumento;

    // Calcular salario bruto
    salarioBruto = SalarioOrdinario + aumento;
    Sistema[Ej, 7] = salarioBruto;

    // Calcular deducción CCSS
    deduccionCCSS = salarioBruto * 0.0917;
    Sistema[Ej,8] = deduccionCCSS;  

    // Calcular salario neto
    salarioNeto = salarioBruto - deduccionCCSS;
    Sistema[Ej,9] = salarioNeto;

    // Mostrar la información del empleado
    Console.WriteLine("\n***** Información del Empleado *****");
    Console.WriteLine("Cédula: {0}", Sistema[Ej, 0]);
    Console.WriteLine("Nombre: {0}", Sistema[Ej, 1]);
    Console.WriteLine("Tipo de empleado: {0}", Sistema[Ej, 2]);
    Console.WriteLine("Cantidad de horas trabajadas: {0}", Sistema[Ej, 3]);
    Console.WriteLine("Precio por hora: {0:C}", Sistema[Ej, 4]);
    Console.WriteLine("Salario ordinario: {0:C}", Sistema[Ej, 5]);
    Console.WriteLine("Aumento: {0:C}", Sistema[Ej, 6]);
    Console.WriteLine("Salario bruto: {0:C}", Sistema[Ej, 7]);
    Console.WriteLine("Deducción CCSS: {0:C}", Sistema[Ej, 8]);
    Console.WriteLine("Salario neto: {0:C}", Sistema[Ej, 9]);

    // Preguntar al usuario si desea registrar otro empleado
    Console.Write("\n¿Desea registrar otro empleado? (s/n): ");
    Finalizador = Console.ReadLine();
    Console.WriteLine(); // Agregar una línea en blanco para mejorar la presentación

} while (Finalizador.ToLower() == "s");