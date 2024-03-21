import iziToast, { IziToastPosition, IziToastSettings } from 'izitoast';
import 'izitoast/dist/css/iziToast.min.css';

export default class Toast {
    static show(type: 'info' | 'success' | 'warning' | 'error') {
        function showToast(message: string | JQuery.jqXHR<any>, timeout?: number, position?: IziToastPosition, params: IziToastSettings = {}) {
            // Verifica se message é um objeto jqXHR. Se sim, tenta extrair a mensagem de texto.
            let finalMessage = typeof message === 'string' ? message : message.responseText || "Ocorreu um erro inesperado.";

            iziToast[type]({
                message: finalMessage,
                timeout: timeout || 10000,
                position: position || 'bottomCenter',
                displayMode: 2,
                ...params
            });
        }

        return function (message: string | JQuery.jqXHR<any>, timeout?: number, position?: IziToastPosition) {
            if (typeof message !== 'string' && 'responseText' in message && message.responseText) {
                if (message.responseText[0] !== '{' && message.responseText[0] !== '[')
                    showToast(message.responseText, timeout, position);
                else {
                    try {
                        const content = JSON.parse(message.responseText);
                        if (content.messages && content.messages.length > 0)
                            content.messages.forEach((msg: string) => showToast(msg, timeout, position));
                        else
                            showToast("Erro não especificado.", timeout, position);
                    } catch (e) {
                        showToast("Erro ao analisar resposta JSON.", timeout, position);
                    }
                }
            } else {
                showToast(message, timeout, position);
            }
        };
    }

    static info = Toast.show('info');
    static success = Toast.show('success');
    static warning = Toast.show('warning');
    static error = Toast.show('error');

    static clear() {
        iziToast.destroy();
    }
}
