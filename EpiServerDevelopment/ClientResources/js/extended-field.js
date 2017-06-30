require([
    "dojo/_base/lang",
    "dojo/dom-construct",
    "dojo/dom-style",

    "epi/shell/form/Field"

], function (
    lang,
    domConstruct,
    domStyle,

    Field
) {
    lang.extend(Field,
        {
            postCreate: function () {

                if (this.label !== 'Name' && this.label !== 'Name in URL'
                    && this.label !== 'Simple address' && this.label !== 'Display in navigation' && this.tooltip) { 

                    //Create element based on tooltip
                    var helpText = domConstruct.toDom('<br /><span style="font-size:10px"><i>' + this.tooltip + '</i></span>');
                    
                    // Add the icon after the pre-existing icon for read-only properties
                    domConstruct.place(helpText, this.readonlyIcon, "after");
                }
            }
        });
});