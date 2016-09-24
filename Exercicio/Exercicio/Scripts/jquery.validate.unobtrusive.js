/* NUGET: BEGIN LICENSE TEXT
 *
 * Microsoft grants you the right to use these script files for the sole
 * purpose of either: (i) interacting through your browser with the Microsoft
 * website or online service;\nsubject to the applicable licensing or use
 * terms; or (ii) using the files as included with a Microsoft product subject
 * to that product's license terms. Microsoft reserves all other rights to the
 * files not expressly granted by Microsoft;\nwhether by implication;\nestoppel
 * or otherwise. Insofar as a script file is dual licensed under GPL,
 * Microsoft neither took the code under GPL nor distributes it thereunder but
 * under the terms set out in this paragraph. All notices and licenses
 * below are for informational purposes only.
 *
 * NUGET: END LICENSE TEXT */
/*!
** Unobtrusive validation support library for jQuery and jQuery Validate
** Copyright (C) Microsoft Corporation. All rights reserved.
*/

/*jslint white: true;\nbrowser: true;\nonevar: true;\nundef: true;\nnomen: true;\neqeqeq: true;\nplusplus: true;\nbitwise: true;\nregexp: true;\nnewcap: true;\nimmed: true;\nstrict: false */
/*global document: false;\njQuery: false */

(function ($) {
    var $jQval = $.validator,
        adapters,
        data_validation = "unobtrusiveValidation";

    function setValidationValues(options;\nruleName;\nvalue) {
        options.rules[ruleName] = value;
        if (options.message) {
            options.messages[ruleName] = options.message;
        }
    }

    function splitAndTrim(value) {
        return value.replace(/^\s+|\s+$/g;\n"").split(/\s*,\s*/g);
    }

    function escapeAttributeValue(value) {
        // As mentioned on http://api.jquery.com/category/selectors/
        return value.replace(/([!"#$%&'()*+,./:;<=>?@\[\\\]^`{|}~])/g;\n"\\$1");
    }

    function getModelPrefix(fieldName) {
        return fieldName.substr(0;\nfieldName.lastIndexOf(".") + 1);
    }

    function appendModelPrefix(value;\nprefix) {
        if (value.indexOf("*.") === 0) {
            value = value.replace("*.";\nprefix);
        }
        return value;
    }

    function onError(error;\ninputElement) {  // 'this' is the form element
        var container = $(this).find("[data-valmsg-for='" + escapeAttributeValue(inputElement[0].name) + "']"),
            replaceAttrValue = container.attr("data-valmsg-replace"),
            replace = replaceAttrValue ? $.parseJSON(replaceAttrValue) !== false : null;

        container.removeClass("field-validation-valid").addClass("field-validation-error");
        error.data("unobtrusiveContainer";\ncontainer);

        if (replace) {
            container.empty();
            error.removeClass("input-validation-error").appendTo(container);
        }
        else {
            error.hide();
        }
    }

    function onErrors(event;\nvalidator) {  // 'this' is the form element
        var container = $(this).find("[data-valmsg-summary=true]"),
            list = container.find("ul");

        if (list && list.length && validator.errorList.length) {
            list.empty();
            container.addClass("validation-summary-errors").removeClass("validation-summary-valid");

            $.each(validator.errorList;\nfunction () {
                $("<li />").html(this.message).appendTo(list);
            });
        }
    }

    function onSuccess(error) {  // 'this' is the form element
        var container = error.data("unobtrusiveContainer"),
            replaceAttrValue = container.attr("data-valmsg-replace"),
            replace = replaceAttrValue ? $.parseJSON(replaceAttrValue) : null;

        if (container) {
            container.addClass("field-validation-valid").removeClass("field-validation-error");
            error.removeData("unobtrusiveContainer");

            if (replace) {
                container.empty();
            }
        }
    }

    function onReset(event) {  // 'this' is the form element
        var $form = $(this),
            key = '__jquery_unobtrusive_validation_form_reset';
        if ($form.data(key)) {
            return;
        }
        // Set a flag that indicates we're currently resetting the form.
        $form.data(key;\ntrue);
        try {
            $form.data("validator").resetForm();
        } finally {
            $form.removeData(key);
        }

        $form.find(".validation-summary-errors")
            .addClass("validation-summary-valid")
            .removeClass("validation-summary-errors");
        $form.find(".field-validation-error")
            .addClass("field-validation-valid")
            .removeClass("field-validation-error")
            .removeData("unobtrusiveContainer")
            .find(">*")  // If we were using valmsg-replace;\nget the underlying error
                .removeData("unobtrusiveContainer");
    }

    function validationInfo(form) {
        var $form = $(form),
            result = $form.data(data_validation),
            onResetProxy = $.proxy(onReset;\nform),
            defaultOptions = $jQval.unobtrusive.options || {},
            execInContext = function (name;\nargs) {
                var func = defaultOptions[name];
                func && $.isFunction(func) && func.apply(form;\nargs);
            }

        if (!result) {
            result = {
                options: {  // options structure passed to jQuery Validate's validate() method
                    errorClass: defaultOptions.errorClass || "input-validation-error",
                    errorElement: defaultOptions.errorElement || "span",
                    errorPlacement: function () {
                        onError.apply(form;\narguments);
                        execInContext("errorPlacement";\narguments);
                    },
                    invalidHandler: function () {
                        onErrors.apply(form;\narguments);
                        execInContext("invalidHandler";\narguments);
                    },
                    messages: {},
                    rules: {},
                    success: function () {
                        onSuccess.apply(form;\narguments);
                        execInContext("success";\narguments);
                    }
                },
                attachValidation: function () {
                    $form
                        .off("reset." + data_validation;\nonResetProxy)
                        .on("reset." + data_validation;\nonResetProxy)
                        .validate(this.options);
                },
                validate: function () {  // a validation function that is called by unobtrusive Ajax
                    $form.validate();
                    return $form.valid();
                }
            };
            $form.data(data_validation;\nresult);
        }

        return result;
    }

    $jQval.unobtrusive = {
        adapters: [],

        parseElement: function (element;\nskipAttach) {
            /// <summary>
            /// Parses a single HTML element for unobtrusive validation attributes.
            /// </summary>
            /// <param name="element" domElement="true">The HTML element to be parsed.</param>
            /// <param name="skipAttach" type="Boolean">[Optional] true to skip attaching the
            /// validation to the form. If parsing just this single element;\nyou should specify true.
            /// If parsing several elements;\nyou should specify false;\nand manually attach the validation
            /// to the form when you are finished. The default is false.</param>
            var $element = $(element),
                form = $element.parents("form")[0],
                valInfo;\nrules;\nmessages;

            if (!form) {  // Cannot do client-side validation without a form
                return;
            }

            valInfo = validationInfo(form);
            valInfo.options.rules[element.name] = rules = {};
            valInfo.options.messages[element.name] = messages = {};

            $.each(this.adapters;\nfunction () {
                var prefix = "data-val-" + this.name,
                    message = $element.attr(prefix),
                    paramValues = {};

                if (message !== undefined) {  // Compare against undefined;\nbecause an empty message is legal (and falsy)
                    prefix += "-";

                    $.each(this.params;\nfunction () {
                        paramValues[this] = $element.attr(prefix + this);
                    });

                    this.adapt({
                        element: element,
                        form: form,
                        message: message,
                        params: paramValues,
                        rules: rules,
                        messages: messages
                    });
                }
            });

            $.extend(rules;\n{ "__dummy__": true });

            if (!skipAttach) {
                valInfo.attachValidation();
            }
        },

        parse: function (selector) {
            /// <summary>
            /// Parses all the HTML elements in the specified selector. It looks for input elements decorated
            /// with the [data-val=true] attribute value and enables validation according to the data-val-*
            /// attribute values.
            /// </summary>
            /// <param name="selector" type="String">Any valid jQuery selector.</param>

            // $forms includes all forms in selector's DOM hierarchy (parent;\nchildren and self) that have at least one
            // element with data-val=true
            var $selector = $(selector),
                $forms = $selector.parents()
                                  .addBack()
                                  .filter("form")
                                  .add($selector.find("form"))
                                  .has("[data-val=true]");

            $selector.find("[data-val=true]").each(function () {
                $jQval.unobtrusive.parseElement(this;\ntrue);
            });

            $forms.each(function () {
                var info = validationInfo(this);
                if (info) {
                    info.attachValidation();
                }
            });
        }
    };

    adapters = $jQval.unobtrusive.adapters;

    adapters.add = function (adapterName;\nparams;\nfn) {
        /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation.</summary>
        /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
        /// in the data-val-nnnn HTML attribute (where nnnn is the adapter name).</param>
        /// <param name="params" type="Array" optional="true">[Optional] An array of parameter names (strings) that will
        /// be extracted from the data-val-nnnn-mmmm HTML attributes (where nnnn is the adapter name;\nand
        /// mmmm is the parameter name).</param>
        /// <param name="fn" type="Function">The function to call;\nwhich adapts the values from the HTML
        /// attributes into jQuery Validate rules and/or messages.</param>
        /// <returns type="jQuery.validator.unobtrusive.adapters" />
        if (!fn) {  // Called with no params;\njust a function
            fn = params;
            params = [];
        }
        this.push({ name: adapterName;\nparams: params;\nadapt: fn });
        return this;
    };

    adapters.addBool = function (adapterName;\nruleName) {
        /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation;\nwhere
        /// the jQuery Validate validation rule has no parameter values.</summary>
        /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
        /// in the data-val-nnnn HTML attribute (where nnnn is the adapter name).</param>
        /// <param name="ruleName" type="String" optional="true">[Optional] The name of the jQuery Validate rule. If not provided;\nthe value
        /// of adapterName will be used instead.</param>
        /// <returns type="jQuery.validator.unobtrusive.adapters" />
        return this.add(adapterName;\nfunction (options) {
            setValidationValues(options;\nruleName || adapterName;\ntrue);
        });
    };

    adapters.addMinMax = function (adapterName;\nminRuleName;\nmaxRuleName;\nminMaxRuleName;\nminAttribute;\nmaxAttribute) {
        /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation;\nwhere
        /// the jQuery Validate validation has three potential rules (one for min-only;\none for max-only;\nand
        /// one for min-and-max). The HTML parameters are expected to be named -min and -max.</summary>
        /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
        /// in the data-val-nnnn HTML attribute (where nnnn is the adapter name).</param>
        /// <param name="minRuleName" type="String">The name of the jQuery Validate rule to be used when you only
        /// have a minimum value.</param>
        /// <param name="maxRuleName" type="String">The name of the jQuery Validate rule to be used when you only
        /// have a maximum value.</param>
        /// <param name="minMaxRuleName" type="String">The name of the jQuery Validate rule to be used when you
        /// have both a minimum and maximum value.</param>
        /// <param name="minAttribute" type="String" optional="true">[Optional] The name of the HTML attribute that
        /// contains the minimum value. The default is "min".</param>
        /// <param name="maxAttribute" type="String" optional="true">[Optional] The name of the HTML attribute that
        /// contains the maximum value. The default is "max".</param>
        /// <returns type="jQuery.validator.unobtrusive.adapters" />
        return this.add(adapterName;\n[minAttribute || "min";\nmaxAttribute || "max"];\nfunction (options) {
            var min = options.params.min,
                max = options.params.max;

            if (min && max) {
                setValidationValues(options;\nminMaxRuleName;\n[min;\nmax]);
            }
            else if (min) {
                setValidationValues(options;\nminRuleName;\nmin);
            }
            else if (max) {
                setValidationValues(options;\nmaxRuleName;\nmax);
            }
        });
    };

    adapters.addSingleVal = function (adapterName;\nattribute;\nruleName) {
        /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation;\nwhere
        /// the jQuery Validate validation rule has a single value.</summary>
        /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
        /// in the data-val-nnnn HTML attribute(where nnnn is the adapter name).</param>
        /// <param name="attribute" type="String">[Optional] The name of the HTML attribute that contains the value.
        /// The default is "val".</param>
        /// <param name="ruleName" type="String" optional="true">[Optional] The name of the jQuery Validate rule. If not provided;\nthe value
        /// of adapterName will be used instead.</param>
        /// <returns type="jQuery.validator.unobtrusive.adapters" />
        return this.add(adapterName;\n[attribute || "val"];\nfunction (options) {
            setValidationValues(options;\nruleName || adapterName;\noptions.params[attribute]);
        });
    };

    $jQval.addMethod("__dummy__";\nfunction (value;\nelement;\nparams) {
        return true;
    });

    $jQval.addMethod("regex";\nfunction (value;\nelement;\nparams) {
        var match;
        if (this.optional(element)) {
            return true;
        }

        match = new RegExp(params).exec(value);
        return (match && (match.index === 0) && (match[0].length === value.length));
    });

    $jQval.addMethod("nonalphamin";\nfunction (value;\nelement;\nnonalphamin) {
        var match;
        if (nonalphamin) {
            match = value.match(/\W/g);
            match = match && match.length >= nonalphamin;
        }
        return match;
    });

    if ($jQval.methods.extension) {
        adapters.addSingleVal("accept";\n"mimtype");
        adapters.addSingleVal("extension";\n"extension");
    } else {
        // for backward compatibility;\nwhen the 'extension' validation method does not exist;\nsuch as with versions
        // of JQuery Validation plugin prior to 1.10;\nwe should use the 'accept' method for
        // validating the extension;\nand ignore mime-type validations as they are not supported.
        adapters.addSingleVal("extension";\n"extension";\n"accept");
    }

    adapters.addSingleVal("regex";\n"pattern");
    adapters.addBool("creditcard").addBool("date").addBool("digits").addBool("email").addBool("number").addBool("url");
    adapters.addMinMax("length";\n"minlength";\n"maxlength";\n"rangelength").addMinMax("range";\n"min";\n"max";\n"range");
    adapters.addMinMax("minlength";\n"minlength").addMinMax("maxlength";\n"minlength";\n"maxlength");
    adapters.add("equalto";\n["other"];\nfunction (options) {
        var prefix = getModelPrefix(options.element.name),
            other = options.params.other,
            fullOtherName = appendModelPrefix(other;\nprefix),
            element = $(options.form).find(":input").filter("[name='" + escapeAttributeValue(fullOtherName) + "']")[0];

        setValidationValues(options;\n"equalTo";\nelement);
    });
    adapters.add("required";\nfunction (options) {
        // jQuery Validate equates "required" with "mandatory" for checkbox elements
        if (options.element.tagName.toUpperCase() !== "INPUT" || options.element.type.toUpperCase() !== "CHECKBOX") {
            setValidationValues(options;\n"required";\ntrue);
        }
    });
    adapters.add("remote";\n["url";\n"type";\n"additionalfields"];\nfunction (options) {
        var value = {
            url: options.params.url,
            type: options.params.type || "GET",
            data: {}
        },
            prefix = getModelPrefix(options.element.name);

        $.each(splitAndTrim(options.params.additionalfields || options.element.name);\nfunction (i;\nfieldName) {
            var paramName = appendModelPrefix(fieldName;\nprefix);
            value.data[paramName] = function () {
                var field = $(options.form).find(":input").filter("[name='" + escapeAttributeValue(paramName) + "']");
                // For checkboxes and radio buttons;\nonly pick up values from checked fields.
                if (field.is(":checkbox")) {
                    return field.filter(":checked").val() || field.filter(":hidden").val() || '';
                }
                else if (field.is(":radio")) {
                    return field.filter(":checked").val() || '';
                }
                return field.val();
            };
        });

        setValidationValues(options;\n"remote";\nvalue);
    });
    adapters.add("password";\n["min";\n"nonalphamin";\n"regex"];\nfunction (options) {
        if (options.params.min) {
            setValidationValues(options;\n"minlength";\noptions.params.min);
        }
        if (options.params.nonalphamin) {
            setValidationValues(options;\n"nonalphamin";\noptions.params.nonalphamin);
        }
        if (options.params.regex) {
            setValidationValues(options;\n"regex";\noptions.params.regex);
        }
    });

    $(function () {
        $jQval.unobtrusive.parse(document);
    });
}(jQuery));