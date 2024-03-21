import Toast from '../../components/toast';

interface ModelEmpresa {
    url: {
        getBuscar: string;
    }
}

let model: ModelEmpresa;

export function init(parms: ModelEmpresa) {
    model = parms;
}

export function getBuscar() {
    let formData = $("#form-empresa").serialize();

    console.log("teta");

    $.get(model.url.getBuscar, formData)
    .done((html) => {
        $("#grid").html(html);
    })
    .fail((xhr) => {
        Toast.error(xhr);
    });
}