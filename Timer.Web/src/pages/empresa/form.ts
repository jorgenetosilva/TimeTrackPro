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

function formularioCepEmpresa() {
    function configurarCamposEndereco(dados: any) {
        const campos = {
            'Endereco': 'logradouro',
            'Bairro': 'bairro',
            'Cidade': 'localidade',
            'Estado': 'uf'
        };

        Object.entries(campos).forEach(([campoForm, campoAPI]) => {
            const seletor = `[name='${campoForm}']`;
            $(seletor).val(dados ? dados[campoAPI] : "");
        });
    }

    function buscarCep(cep: any) {
        if (/^[0-9]{8}$/.test(cep)) {
            $.get(`https://viacep.com.br/ws/${cep}/json/`).done((data) => {
                if (data && !data.erro) {
                    configurarCamposEndereco(data);
                } else {
                    alert("Dados do CEP não encontrados.");
                    configurarCamposEndereco(null);
                }
            }).fail(() => {
                alert("Erro ao buscar o CEP.");
                configurarCamposEndereco(null);
            });
        } else {
            alert("Formato de CEP inválido.");
            configurarCamposEndereco(null);
        }
    }

    $("[name='Cep']").on('blur', function () {
        var cepValue = $(this).val();
        if (typeof cepValue === 'string') {
            var cep = cepValue.replace(/\D/g, '');
            if (cep) {
                buscarCep(cep);
            } else {
                alert("CEP inválido.");
            }
        } else {
            alert("O valor do CEP deve ser uma string.");
        }
    });
}

formularioCepEmpresa();
