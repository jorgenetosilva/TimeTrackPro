// import $ from 'jquery';
// import String  from 'helpers/string';
// import 'jquery-mask-plugin';

// function getRules(element: Element)
// {
//     var input = $(element),
//         dataRules = input.attr('data-rules');

//     var rules = (dataRules ? dataRules.split(';') : []).map(function (item) {
//         var rule = item.split(':');
//         return { name: rule[0].trim(), options: rule[1] ? rule[1].trim() : undefined };
//     }).filter(function (rule) { return rule.name; });

//     return rules;
// }

// function rule(element: Element, condition, message: string, type: string = null) {
//     var input = $(element),
//         formControl = input.closest('.uk-form-controls, .uk-inline'),
//         messageContainer = formControl.find('.message');

//     type = type || 'error';

//     if (condition) {
//         formControl.removeClass('warning error').addClass(type);
//         if (!messageContainer.length) {
//             messageContainer = $('<div/>', { 'class': 'message error uk-text-danger' });
//             formControl.append(messageContainer);
//         }

//         input.addClass('uk-form-danger');
//         messageContainer.html(message);
//     } else {
//         formControl.removeClass('warning error');
//         input.removeClass('uk-form-danger');
//         messageContainer.remove();
//     }

//     return condition;
// };

// $.ajaxSetup({ cache: false });
// ['put', 'delete'].forEach(function (type) {
//     $[type] = function (url, data) {
//         return $.ajax({
//             url: url,
//             type: type.toUpperCase(),
//             data: data ? JSON.stringify(data) : undefined,
//             contentType: 'application/json'
//         });
//     };
// });

// $(function() {
//     DatePicker.init($(document).find('[data-rules*="date"]'));
// })

// let pendingAjax = [];
// $(document).on('ajaxSend', function (e, xhr) {
//     xhr.id = new Date().getTime();
//     xhr.loading = $(document).data('showLoading') !== false;
//     pendingAjax.push(xhr);

//     if (xhr.loading)
//         Loading.show('');

//     $(document).data('showLoading', true);
// }).on('ajaxComplete', function (e, xhr, b) {
//     pendingAjax = pendingAjax.filter(function (ajax) { return ajax.id !== xhr.id; });
//     if (pendingAjax.every(function (ajax) { return !ajax.loading; }))
//         Loading.hide();

// }).on('ajaxError', function (e, xhr) {
//     if (xhr.status === 401) {
//         alert('Sessão expirada. Efetue o login novamente!');
//         location.reload();
//     }
// }).on('keydown input blur', '[data-rules]', function (e) {
//     var input: JQuery<HTMLElement> = $(e.currentTarget),
//         rules = getRules(e.currentTarget),
//         value = (input.val().toString() || '').trim(),
//         condition = false;

//     for (var i = 0; i < rules.length; i++) {
//         switch (rules[i].name) {
//             case 'required':
//                 var empty = false;
//                 input.closest('.uk-form-controls').find('input, select, textarea').each(function () {
//                     if (empty)
//                         return;

//                     var inputValue = ($(this).val().toString() || '').trim();
//                     if (!inputValue)
//                         empty = true;
//                 });
//                 condition = rule(e.currentTarget, empty, 'Campo obrigatório');
//                 break;
//             case 'number':
//                 input.mask('#0', { reverse: true });
//                 condition = rule(e.currentTarget, value && isNaN(+value), 'Número inválido');
//                 break;
//             case 'date':
//                 condition = rule(e.currentTarget, value && !String.isValidDate(value), 'Data inválida');
//                 break;
//             case 'email':
//                 condition = rule(e.currentTarget, value && !String.isValidEmail(value), 'E-mail inválido');
//                 break;
//             case 'cpf':
//                 input.mask('000.000.000-00', { reverse: true });
//                 condition = rule(e.currentTarget, value && !String.isValidCpf(value), 'CPF inválido');
//                 break;
//             case 'cnpj':
//                 input.mask('00.000.000/0000-00', { reverse: true });
//                 condition = rule(e.currentTarget, value && !String.isValidCnpj(value), 'CNPJ inválido');
//                 break;
//             case 'cep':
//                 input.mask('00000-000', { reverse: true });
//                 condition = rule(e.currentTarget, value && !String.isValidCep(value), 'CEP inválido');
//                 break;
//             case 'fone':
//                 if (!value || value.length <= 14)
//                     input.mask('(00) 0000-00009');
//                 else
//                     input.mask('(00) 00000-0000');
//                 condition = rule(e.currentTarget, value && value.length < 14, 'Telefone inválido');
//                 break;
//             default:
//                 console.error('Invalid Rule: ' + rules[i].name);
//                 break;
//         }

//         if (condition)
//             return;
//     }
// });

// export default $;
