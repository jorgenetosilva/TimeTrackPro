import $ from 'jquery';

interface SerializedForm {
    [key: string]: any; 
    isValid?: boolean; 
    length?: number; 
    emptyLength?: number;
    requiredEmptyLength?: number;
}

export default class Form {
    static serializeObject(element: any, options?: {
        verifyEmpty: boolean
    }): SerializedForm { // Anotação do tipo de retorno
        var form = $(element);
        if (!form.is('form')) {
            form = form.wrap('<form/>').parent();
            var obj = this.serializeObject(form, options);
            form.children().unwrap('form');
            return obj;
        }

        var obj: SerializedForm = {}, // Uso da interface para o tipo do objeto
            arr = form.serializeArray();
        for (var i = 0; i < arr.length; i++)
            obj[arr[i].name] = arr[i].value;

        form.find('.uk-form-controls, .uk-inline').find('input, select, textarea').trigger('input');
        obj.isValid = !form.find('.uk-form-controls.error, .uk-inline.error').length;

        if (!options)
            return obj;

        obj.length = arr.length;
        if (options.verifyEmpty) {
            var focused = false;
            for (var prop in obj)
                if (!obj[prop].toString().trim()) {
                    obj.emptyLength = (obj.emptyLength || 0) + 1;

                    var input = form.find('[name="' + prop + '"]');
                    if (input.is('.required:visible')) {
                        obj.requiredEmptyLength = (obj.requiredEmptyLength || 0) + 1;
                        input.trigger('input');

                        if (!focused) {
                            input.focus();
                            focused = true;
                        }
                    }
                }
        }

        return obj;
    }
}
