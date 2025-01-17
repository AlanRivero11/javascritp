/**
 * Calcula el promedio de una lista de números.
 * @param {number[]} numbers - Array de números para calcular el promedio.
 * @returns {number} El promedio de los números proporcionados.
 * @throws {Error} Si el array está vacío o contiene elementos no numéricos.
 */
function calcularPromedio(numbers) {
    // Verificar si el array está vacío
    if (!Array.isArray(numbers) || numbers.length === 0) {
        throw new Error("El array debe contener al menos un número.");
    }

    // Validar que todos los elementos sean números
    if (!numbers.every(num => typeof num === "number")) {
        throw new Error("Todos los elementos del array deben ser números.");
    }

    // Calcular la suma de los números
    const sumaTotal = numbers.reduce((suma, numero) => suma + numero, 0);

    // Calcular y devolver el promedio
    return sumaTotal / numbers.length;
}

/**
 * Solicita al usuario una lista de números, calcula y muestra el promedio.
 */
function manejarCalculo() {
    try {
        // Solicitar al usuario una lista de números separados por comas
        const inputNumeros = prompt("Introduce una lista de números separados por comas (por ejemplo: 10, 20, 30):");

        if (!inputNumeros) {
            throw new Error("No se ha ingresado ningún dato.");
        }

        // Convertir la entrada del usuario en un array de números
        const listaNumeros = inputNumeros
            .split(",") // Dividir la cadena en un array por las comas
            .map(num => {
                const numero = parseFloat(num.trim());
                if (isNaN(numero)) {
                    throw new Error("Introduce solo números separados por comas.");
                }
                return numero;
            });

        // Calcular el promedio
        const promedio = calcularPromedio(listaNumeros);

        // Mostrar el resultado
        console.log(`El promedio de la lista es: ${promedio}`);
        alert(`El promedio de la lista es: ${promedio}`);
    } catch (error) {
        // Manejar errores y mostrarlos en la consola y con una alerta
        console.error(`Error: ${error.message}`);
        alert(`Error: ${error.message}`);
    }
}

// Ejecutar el programa
manejarCalculo();
