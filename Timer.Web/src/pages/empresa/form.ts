import Toast from '../../components/toast';
import Form from '../../helpers/form';
import $ from 'jquery';
import 'jquery-mask-plugin';

interface ModelEmpresaForm {
    url: {
        cadastrar: string;
        index: string;
        post: string;
    }
}

let model: ModelEmpresaForm;

export function init(parms: ModelEmpresaForm) {
    model = parms;
}


export function post() {
    let data = Form.serializeObject($("#form-cadastrar-empresa"));

    console.log(data);

    if (!data.isValid)
        return;

    $.post(model.url.cadastrar, data)
        .done(() => {
            window.location.href = model.url.index;
        })
        .fail((xhr) => {
            Toast.error(xhr.responseText);
        });
}

// function validarDados(obj) {
//     obj.RGrepresentante = String.unmask(obj.RGrepresentante.toString());
//     obj.RGTestemunha1 = String.unmask(obj.RGTestemunha1.toString());
//     obj.RGTestemunha2 = String.unmask(obj.RGTestemunha2.toString());
//     obj.CNPJ = String.unmask(obj.CNPJ.toString());
//     obj.CEP = String.unmask(obj.CEP.toString());
//     obj.CEPrepresentante = String.unmask(obj.CEPrepresentante.toString());

//     return true;
// }