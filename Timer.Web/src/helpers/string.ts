// export default class String {

//     static removeAccents(value: string) {
//         var str = value.split('');
//         var strAccentsOut = new Array(),
//             strAccentsLen = str.length,
//             accents = 'ÀÁÂÃÄÅàáâãäåÒÓÔÕÕÖØòóôõöøÈÉÊËèéêëðÐÌÍÎÏìíîïÙÚÛÜùúûüÑñŠšŸÿýŽž',
//             accentsOut = 'AAAAAAaaaaaaOOOOOOOooooooEEEEeeeeeDIIIIiiiiUUUUuuuuNnSsYyyZ';

//         for (var y = 0; y < strAccentsLen; y++)
//             strAccentsOut[y] = accents.indexOf(str[y]) != -1 ? accentsOut.substr(accents.indexOf(str[y]), 1) : str[y];

//         return strAccentsOut.join('');
//     };

//     static unmask(value: string) {
//         return value.replace(/\.|\-|\//g, "");
//     };

//     static padLeft = function (value: string, length: number, caracter?: string) {
//         var str = value.toString();
//         if (!caracter) caracter = '0';

//         while (str.length < length)
//             str = caracter + str;

//         return str;
//     };

//     static padRight = function (value: string, length: number, caracter?: string) {
//         var string = value.toString();
//         if (!caracter) caracter = '0';

//         while (string.length < length)
//             string = string + caracter;

//         return string;
//     };

//     static isValidDate = function (value: string) {
//         return /^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$/.test(value);
//     };

//     static isValidCpf = function (value: string) {
//         var cpf = String.padLeft(String.unmask(value), 11);

//         var digitosIguais = 1;
//         for (var i = 0; i < cpf.length - 1; i++)
//             if (cpf.charAt(i) != cpf.charAt(i + 1)) {
//                 digitosIguais = 0;
//                 break;
//             }

//         if (digitosIguais)
//             return false;

//         var numeros = cpf.substring(0, 9),
//             digitos = cpf.substring(9),
//             soma = 0,
//             resultado;

//         for (var i = 10; i > 1; i--)
//             soma += (+numeros.charAt(10 - i)) * i;

//         resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;

//         if (resultado != digitos.charAt(0))
//             return false;

//         numeros = cpf.substring(0, 10);
//         soma = 0;

//         for (var i = 11; i > 1; i--)
//             soma += (+numeros.charAt(11 - i)) * i;

//         resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;

//         if (resultado != digitos.charAt(1))
//             return false;

//         return true;
//     };

//     static isValidCnpj = function (value: string) {
//         var cnpj = String.padLeft(String.unmask(value), 14);

//         if (cnpj == "00000000000000" || cnpj == "11111111111111" || cnpj == "22222222222222" || cnpj == "33333333333333" || cnpj == "44444444444444" ||
//             cnpj == "55555555555555" || cnpj == "66666666666666" || cnpj == "77777777777777" || cnpj == "88888888888888" || cnpj == "99999999999999")
//             return false;

//         var tamanho = cnpj.length - 2,
//             numeros = cnpj.substring(0, tamanho),
//             digitos = cnpj.substring(tamanho),
//             soma = 0,
//             pos = tamanho - 7;

//         for (var i = tamanho; i >= 1; i--) {
//             soma += (+numeros.charAt(tamanho - i)) * pos--;
//             if (pos < 2)
//                 pos = 9;
//         }

//         var resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
//         if (resultado != (+digitos.charAt(0)))
//             return false;

//         tamanho = tamanho + 1;
//         numeros = cnpj.substring(0, tamanho);
//         soma = 0;
//         pos = tamanho - 7;

//         for (i = tamanho; i >= 1; i--) {
//             soma += (+numeros.charAt(tamanho - i)) * pos--;
//             if (pos < 2)
//                 pos = 9;
//         }

//         resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
//         if (resultado != (+digitos.charAt(1)))
//             return false;

//         return true;
//     };

//     static isValidEmail = function (value: string) {
//         return value.match(/^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/);
//     };

//     static isValidCep(value: string): boolean {
//         const cepRegex = /^\d{5}-?\d{3}$/;
//         return cepRegex.test(value);
//     };

//     static isValidPhone(value: string): boolean {
//         const phoneRegex = /^(?:(?:\+55\s?)?(?:\([1-9]{2}\)\s?)?|[1-9]{2}\s?)?(?:[2-8]|9[1-9])[0-9]{3}\-?[0-9]{4}$/;
//         return phoneRegex.test(value);
//     };
// }
