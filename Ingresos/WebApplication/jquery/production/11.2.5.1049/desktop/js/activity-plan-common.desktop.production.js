function _typeof(t){return(_typeof="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"==typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t})(t)}!function(t){"use strict";t.fn.uicombo=function(e,o){var i=this;return i.config={namespace:t.bizagi.ui.controls.uicombo.namespace,cssComponent:t.bizagi.ui.controls.uicombo.css,internalData:{}},i.settings={data:{},ascombo:!0,disabled:!1,isSearchable:!1,isEditable:!1,nameTemplate:t.bizagi.ui.controls.uicombo.tmpl,nameSubTemplate:t.bizagi.ui.controls.uicombo.tmpl2,initValue:null,itemValue:null,itemText:null,css:"",orientation:"biz-o-left",getTemplate:function(t){return bizagi.getTemplate(t)},initializeTemplates:function(){t.Deferred();var e=this.nameTemplate,o=this.nameSubTemplate;return{combo:bizagi.getTemplate(e),list:bizagi.getTemplate(o)}},onComplete:function(){},onChange:function(){},onComboDropDown:function(){}},i.methods={init:function(e){var o,n=t(this);e.getTemplate(e.nameTemplate),e.getTemplate(e.nameSubTemplate);e.IE=navigator.appName.indexOf("Internet Explorer")>0||(!(!navigator.userAgent.match(/Trident\/7.0/)||navigator.userAgent.match(/MSIE/i))||void 0),n.attr("role",e.namespace),n.addClass(e.cssComponent),n.addClass(e.css),n.loader=new bizagi.ui.controls.tmplloader,t.when(n.loader.loadTemplates(e.initializeTemplates())).done((function(){var a=n.loader.getTemplate("combo"),s=n.loader.getTemplate("list");i.config.internalData=o=e.data,o.isEditable=e.isEditable,o.disabled=e.disabled,i.config.subTemplateHTML=s,e.data.id=Math.guid();var l=t.tmpl(a,e.data,{itemValue:e.itemValue?e.itemValue:i.methods.itemValue,itemText:e.itemText?e.itemText:i.methods.itemText});if(n.append(l),i.config.inputCombo=t(".biz-wp-combo-input",n),l.find(".biz-wp-combo-option").each((function(o,i){e.data.combo[o].data&&t.extend(t(i).data(),e.data.combo[o].data)})),i.settings.onComplete.apply(n,[]),n.methods=i.methods,n.config=i.config,n.settings=i.settings,n.methods.configureHandlers.apply(n,[]),t.event.trigger({type:"comboCompleted",message:"combo is Completed",time:new Date,ui:n}),i.settings.initValue){var c="",r="";r=i.settings.itemText?i.settings.itemText(i.settings.initValue):i.settings.initValue.text,c=i.settings.itemValue?i.settings.itemValue(i.settings.initValue):i.settings.initValue.value,""===r?n.config.inputCombo.val(""):n.config.inputCombo.val(r),i.config.inputCombo.data("value",c)}}))},getControl:function(){return t(".biz-wp-combo",this)},getData:function(){return i.config.internalData},findDataByValue:function(e){if(null!=e){var o="object"===_typeof(e)?e.join(" - "):"boolean"==typeof e?e.toString():e;t.trim(o).substring(0,o.length).toLowerCase(),this.getData()}return-1},configureHandlers:function(){var e=this,o=e.methods.getControl.apply(e,[]);e.config.inputCombo.focus((function(){})),e.config.inputCombo.blur((function(){e.settings.isSearchable&&e.methods.validateValueInDatasource()})),e.config.inputCombo.click((function(){var i="dd-"+e.config.inputCombo.attr("id");0===t("#"+i,o).length?e.methods.comboDropDown.apply(e,[]):e.methods.dropDownDestroy.apply(e,[t(i)]),e.config.inputCombo.select()})),t(".biz-wp-combo-btn",o).bind("click.combo",(function(){e.config.inputCombo.trigger("click").focus()})),e.config.inputCombo.keyup((function(t){e.methods.keyUpFunction.apply(e,[t])})),e.config.inputCombo.keydown((function(t){e.methods.keyDownFunction.apply(e,[t])}))},comboDropDown:function(){var e=this;t.when(e.methods.getData()).done((function(t){e.methods.internalComboDropDown.apply(e,[t]),i.settings.onComboDropDown()}))},internalComboDropDown:function(e){t(".ui-select-dropdown.open").detach();var o,n=this,a={},s=t("<div class='ui-select-dropdown open'></div>"),l=n.config.inputCombo.closest(".biz-wp-combo-data-container"),c=l.closest(".biz-wp-combo"),r="dd-"+n.config.inputCombo.attr("id"),m=n.methods.findDataByValue(n.config.inputCombo.val()),u=0;e=e||n.properties.data,n.repositionInterval;var d=c.css("height"),p=n.methods.getControl.apply(n,[]);c.addClass("ac-is-visible"),c.css("height",d),l.addClass("ac-is-visible ac-clear-floats"),s.attr("id",r),o=t.tmpl(i.config.subTemplateHTML,e,{itemValue:n.settings.itemValue?n.settings.itemValue:n.methods.itemValue,itemText:n.settings.itemText?n.settings.itemText:n.methods.itemText});var h=s.append(o);l.append(h),h.position({my:"left top",at:"left bottom",of:t(".biz-wp-combo-input",p),collision:"none"}).hide(),h.fadeIn(),h.width(p.width()),n.methods.recalculateComboOffset(h,p),h.data("formWidth",l.width()),h.data("parentCombo",p),h.addClass(n.settings.orientation),-1!==m&&((a=t("li[data-value='"+m.id+"']",h)).addClass("ui-selected"),a.addClass("active"),u=parseInt(a.position().top),h.scrollTop(u)),h.on("mouseup","li",(function(e){e.stopPropagation();var o={value:t(this).data("value").toString()?t(this).data("value"):"",text:t(this).text()};n.methods.onComboItemSelected.apply(n,[o]),n.config.inputCombo.focus(),h.fadeOut("slow",(function(){n.methods.dropDownDestroy.apply(n,[h])})),t(document).unbind("click.closecombo")})),t.makeArray(h,n.methods.getControl.apply(n,[])).bind("click",(function(t){return t.preventDefault(),!1})),h.bind("mousedown.closecombo",(function(){h.attr("md",!0)})),t(document).bind("mousedown.resizecombo",(function(e){t(e.target).hasClass("ui-resizable-handle")&&(n.repositionInterval&&clearInterval(n.repositionInterval),n.repositionInterval=setInterval((function(){n.methods.dropDownReposition.apply(n,[h,l])}),10))})),t(document).bind("mouseup.resizecombo",(function(e){clearInterval(n.repositionInterval);var o=t(e.target);h.attr("md")?h.removeAttr("md"):o.hasClass("ui-select-dropdown")||n.methods.dropDownValidClose.apply(n,[o,h])})),t(document).on("mouseup.closecombo",(function(e){var o;o=n.settings.IE&&e.currentTarget.activeElement?e.currentTarget.activeElement:e.target;var i=t(o);h.attr("md")?h.removeAttr("md"):i.hasClass("ui-select-dropdown")||n.methods.dropDownValidClose.apply(n,[i,h])})),t(window).bind("resize.resizecombo",(function(){n.repositionInterval&&clearInterval(n.repositionInterval),n.methods.dropDownReposition.apply(n,[h,l])})),t(document).one("click.closecombo",(function(e){var o=t(e.target);h.attr("md")?h.removeAttr("md"):n.methods.dropDownValidClose.apply(n,[o,h])}))},dropDownValidClose:function(e,o){var i=this;o.fadeOut("slow",(function(){i.methods.dropDownDestroy.apply(i,[o])})),t(document).unbind("click.closecombo")},dropDownReposition:function(e,o){var i=this.methods.getControl.apply(this,[]);o.width()!=e.data("formWidth")&&(e.width(i.width()<100?100:i.width()),e.position({my:"left top",at:"left bottom",of:t(".biz-wp-combo-input",i),collision:"none"}),e.data("formWidth",o.width()))},dropDownDestroy:function(e){var o=this.config.inputCombo.closest(".ui-bizagi-control"),i=o.closest(".ui-bizagi-render");o.hasClass("ac-is-visible")&&o.removeClass("ac-is-visible"),o.hasClass("ac-clear-floats")&&o.removeClass("ac-clear-floats"),i.css("height","auto"),i.hasClass("ac-is-visible")&&i.removeClass("ac-is-visible"),e.remove(),t(document).unbind("mousedown.closecombo"),t(document).unbind("mouseup.resizecombo"),t(window).unbind("resize.resizecombo"),t(window).unbind("mouseup.closecombo"),this.repositionInterval,clearInterval(this.repositionInterval)},validateValueInDatasource:function(){var t=i.config.inputCombo.val(),e=this.findDataByValue(t);this.value||(this.value={id:""}),e.id>0?(this.setValue({id:e.id},!1),this.setDisplayValue(e)):""==e.id?(this.value.id!=e.id&&this.setValue(e,!1),this.setDisplayValue(e)):this.setDisplayValue(this.selectedValue)},keyDownFunction:function(e){var o="dd-"+i.config.inputCombo.attr("id"),n=t("#"+o),a=t("li.active",n);return(e=e||window.event).altKey||e.ctrlKey||e.metaKey?1:(0===n.length&&(this.methods.comboDropDown.apply(this,[]),n=t("#"+o)),e.shiftKey&&e.keyCode?(n.remove(),0):(27==e.keyCode&&(this.methods.setDisplayValue.apply(this,[this.selectedValue]),n.remove()),9==e.keyCode||13==e.keyCode?(a.length>0&&this.config.inputCombo.val(a.text()),this.settings.isSearchable?this.methods.validateValueInDatasource():this.methods.setValue.apply(this,[a.data("value")]),n.remove(),1):"38"==e.keyCode||"37"==e.keyCode?(this.methods.selectPreviousElement.apply(this,[n]),0):"40"==e.keyCode||"39"==e.keyCode?(this.methods.selectNextElement.apply(this,[n]),0):36==e.keyCode?(this.methods.selectFirstElement.apply(this,[n]),0):35==e.keyCode?(this.methods.selectLastElement.apply(this,[n]),0):this.methods.selectFirstPossibleElement.apply(this,[n,i.config.inputCombo.val()+e.key])?0:1))},keyUpFunction:function(e){var o="dd-"+i.config.inputCombo.attr("id"),n=t("#"+o);return(e=e||window.event).altKey||e.ctrlKey||e.metaKey||50==e.keyCode||13==e.keyCode||9==e.keyCode||27==e.keyCode||"38"==e.keyCode||"40"==e.keyCode||e.shiftKey&&e.keyCode||36==e.keyCode||35==e.keyCode||33==e.keyCode||34==e.keyCode?0:(0===n.length&&(this.methods.comboDropDown.apply(this,[]),n=t("#"+o)),this.settings.isSearchable&&this.methods.selectItemByKeyUp.apply(this,[]),1)},selectItemByKeyUp:function(){var e,o="dd-"+i.config.inputCombo.attr("id"),n=t("#"+o);t(".active",n).removeClass("active");var a=this.settings.isSearchable?this.methods.findDataByValue(i.config.inputCombo.val()):-1;-1!==a?(e=t("li[data-value='"+a.id+"']",n)).addClass("active"):e=t("li.ui-selected",n),n.length>0&&e.length>0?(scrollPosition=parseInt(e.position().top),n.scrollTop(scrollPosition)):this.methods.setValue.apply(this,[this.selectedValue])},selectFirstElement:function(e){var o=t("li:first",e);t("li",e).removeClass("active"),o.addClass("active"),scrollPosition=o.position().top,e.scrollTop(scrollPosition),i.config.inputCombo.val(t(o).text())},selectLastElement:function(e){var o=t("li:last",e);t("li",e).removeClass("active"),o.addClass("active"),scrollPosition=o.position().top,e.scrollTop(scrollPosition),i.config.inputCombo.val(t(o).text())},selectFirstPossibleElement:function(e,o){var i=t("li",e),n=t.first(i,(function(e){return 0==t(e).text().toString().toLowerCase().indexOf(o.toLowerCase())}));if(n){t("li",e).removeClass("active"),t(n).addClass("active");var a=t(n).position().top;e.scrollTop(a)}},selectPreviousElement:function(e){var o=0,n=t("li.active",e);0===n.length&&(n=t("li:first",e));var a=n.prev();0!=a.length&&(n.removeClass("active"),t(a).addClass("active"),o=t(a).position().top,e.scrollTop(o),i.config.inputCombo.val(t(a).text()))},selectNextElement:function(e){var o=0,n=t("li.active",e);0===n.length&&(n=t("li:first",e));var a=n.next();0!=a.length&&(n.removeClass("active"),t(a).addClass("active"),o=t(a).position().top,e.scrollTop(o),i.config.inputCombo.val(t(a).text()))},onComboItemSelected:function(t){var e=t.value.toString(),o=t.text||"";this.config.inputCombo.val(o),this.methods.setValue.apply(this,[e,o])},setValue:function(e,o){this.config.inputCombo.data("value",e);var n=this.config.inputCombo,a={type:"comboChange",message:"combo change",time:new Date,ui:n,element:t(".biz-wp-combo",this),value:e,text:o};i.settings.onChange(a),t.event.trigger(a)},setDisplayValue:function(t){null!==(t=i.settings.itemValue?i.settings.itemValue:i.methods.itemValue)?i.config.inputCombo.val(""):null===t&&i.config.inputCombo.val("")},clearDisplayValue:function(){i.config.inputCombo.val(""),this.value=this.properties.value=this.selectedValue},getSelectedValue:function(){return this.selectedValue},recalculateComboOffset:function(t,e){if(bizagi.util.isIE()&&9==bizagi.util.getInternetExplorerVersion()&&t.width()!==e.width()){var o=e.width()-t.width();t.width(e.width()+o)}},itemValue:function(t){var e="";return t.itemValue?e=t.itemValue(t):"string"!=typeof t.value&&"number"!=typeof t.value||(e=t.value),e},itemText:function(t){var e="";return t.itemValue?e=t.itemText(t):"string"==typeof t.text&&(e=t.text),e},destroy:function(e){var o=t(this);o.attr("role")===e.namespace?o.empty():t.error("No es posible eliminar un control con un namespace diferente: [role: "+e.namespace+"]")},selectItem:function(e){var o=t(".biz-wp-combo-input",this);o.val(e.text),o.data("value",e.value)}},"object"!=_typeof(e)&&e?(t.extend(i.settings,o,i.config),i.methods[e].apply(this,[i.settings])):"object"!==_typeof(e)&&e&&void 0!==e?void t.error("Method "+e+" does not exist on jQuery.combo"):(t.extend(i.settings,e,i.config),this.each((function(){i.methods.init.apply(this,[i.settings])})))},t.bizagi.ui.controls.uicombo.plugin=t.fn.uicombo}(jQuery);
//# sourceMappingURL=../../../../Maps/desktop/activity-plan-common.desktop.production.js.map
