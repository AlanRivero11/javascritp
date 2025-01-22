// Función para verificar si un número es primo
function esPrimo(N) {
    if (N <= 1) {
        return false; // Los números menores o iguales a 1 no son primos
    }

    // Verificar divisores desde 2 hasta la raíz cuadrada de N
    for (let i = 2; i <= Math.sqrt(N); i++) {
        if (N % i === 0) {
            return false; // Si se encuentra un divisor, no es primo
        }
    }

    return true; // Si no se encontraron divisores, es primo
}

// Solicitar al usuario un número en un navegador
const numero = parseInt(prompt("Ingresa un número para verificar si es primo:"));

if (!isNaN(numero)) {
    if (esPrimo(numero)) {
        alert(`${numero} es un número primo.`);
    } else {
        alert(`${numero} no es un número primo.`);
    }
} else {
    alert("Por favor, ingresa un número válido.");
}
