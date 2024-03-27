import Toast from '../../components/toast';
import Form from '../../helpers/form';
import $ from 'jquery';
import 'jquery-mask-plugin';

interface ModelEmpresaForm {
    url: {
        cadastrar: string;
        index: string;
        post: string;
        editar: string;
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

export function editar() {
    let obj = Form.serializeObject($("#form-cadastrar-empresa"));

    if (!obj.isValid)
        return;

    $.post({
        url: model.url.editar,
        data: obj
    }).done(() => {
        window.location.href = model.url.index;
    }).fail((xhr) => {
        Toast.error(xhr.responseText);
    });
}
