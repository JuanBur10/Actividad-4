using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Reporte de Atención Veterinaria ===");

        string especieMascota = "perro";
        int edadMascota = 7;
        double peso = 28.5;
        bool tieneVacunasAlDia = false;
        bool esSocio = true;
        string motivoConsulta = "cirugia";

        // Parte 1 — Etapa de vida (switch expression con rangos)
        string etapaVida = edadMascota switch
        {
            < 1 => "Cachorro",
            >= 1 and <= 3 => "Joven",
            >= 4 and <= 8 => "Adulto",
            > 8 => "Senior"
        };

        Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} años | Etapa: {etapaVida}");

        // Parte 2 — Alerta vacunación (if-else con operadores lógicos)
        string alertaVacuna;

        if ((especieMascota == "perro" || especieMascota == "gato") && !tieneVacunasAlDia)
        {
            alertaVacuna = "ALERTA: vacunación urgente requerida";
        }
        else if ((especieMascota == "perro" || especieMascota == "gato") && tieneVacunasAlDia)
        {
            alertaVacuna = "Vacunación al día";
        }
        else
        {
            alertaVacuna = "Esquema de vacunación no aplica";
        }

        Console.WriteLine($"Estado de vacunación: {alertaVacuna}");

        // Parte 3 — Costo base (switch tradicional)
        decimal costoBase;

        switch (motivoConsulta)
        {
            case "vacuna":
                costoBase = 35000;
                break;
            case "revision":
                costoBase = 50000;
                break;
            case "cirugia":
                costoBase = 280000;
                break;
            case "urgencia":
                costoBase = 150000;
                break;
            default:
                costoBase = 0;
                break;
        }

        Console.WriteLine($"Motivo: {motivoConsulta} | Costo base: ${costoBase:N0}");

        // Parte 4 — Descuento (operador ternario)
        double porcentajeDescuento = esSocio
            ? (peso > 25 ? 15.0 : 10.0)
            : 0.0;

        decimal descuento = costoBase * (decimal)(porcentajeDescuento / 100);
        decimal costoFinal = costoBase - descuento;

        Console.WriteLine($"Descuento: {porcentajeDescuento}% | Costo final: ${costoFinal:N0}");

        // Parte 5 — Recomendación (if-else anidado)
        string recomendacion;

        if (motivoConsulta == "cirugia")
        {
            if (etapaVida == "Senior")
            {
                recomendacion = "Reposo absoluto por 10 días, control post-operatorio obligatorio";
            }
            else
            {
                recomendacion = "Reposo por 5 días, evitar ejercicio intenso";
            }
        }
        else if (motivoConsulta == "urgencia")
        {
            if (!tieneVacunasAlDia)
            {
                recomendacion = "Atender urgencia y programar vacunación inmediata";
            }
            else
            {
                recomendacion = "Seguimiento en 48 horas";
            }
        }
        else
        {
            recomendacion = "Seguimiento en próxima consulta de rutina";
        }

        Console.WriteLine($"Recomendación: {recomendacion}");
    }
}
