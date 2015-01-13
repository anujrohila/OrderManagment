/* Load this script using conditional IE comments if you need to support IE 7 and IE 6. */

window.onload = function() {
	function addIcon(el, entity) {
		var html = el.innerHTML;
		el.innerHTML = '<span style="font-family: \'FLSmidth.ICLCom-Icon-Font\'">' + entity + '</span>' + html;
	}
	var icons = {
			'icon-add-to-list' : '&#x22;',
			'icon-access' : '&#x23;',
			'icon-copy' : '&#x24;',
			'icon-export' : '&#x25;',
			'icon-save' : '&#x26;',
			'icon-sort' : '&#x27;',
			'icon-chevron-left' : '&#x28;',
			'icon-chevron-right' : '&#x29;',
			'icon-cascade' : '&#x2a;',
			'icon-email' : '&#x2b;',
			'icon-cancel' : '&#x2c;',
			'icon-website' : '&#x2d;',
			'icon-link' : '&#x2e;',
			'icon-index' : '&#x2f;',
			'icon-print' : '&#x30;',
			'icon-contents' : '&#x31;',
			'icon-tree' : '&#x32;',
			'icon-create_jf' : '&#x33;',
			'icon-glass' : '&#x34;',
			'icon-arrow-circle-down' : '&#x35;',
			'icon-edit' : '&#x36;',
			'icon-create_user' : '&#x37;',
			'icon-arrow-circle-back' : '&#x38;',
			'icon-check-circle' : '&#x39;',
			'icon-check' : '&#x3a;',
			'icon-access_enable' : '&#x3b;',
			'icon-access_disable' : '&#x3c;',
			'icon-dashboard' : '&#x3d;',
			'icon-users' : '&#x3e;',
			'icon-company' : '&#x3f;',
			'icon-jobfunctions' : '&#x40;',
			'icon-approvals' : '&#x41;',
			'icon-icon_arrow_down' : '&#x21;'
		},
		els = document.getElementsByTagName('*'),
		i, attr, html, c, el;
	for (i = 0; ; i += 1) {
		el = els[i];
		if(!el) {
			break;
		}
		attr = el.getAttribute('data-icon');
		if (attr) {
			addIcon(el, attr);
		}
		c = el.className;
		c = c.match(/icon-[^\s'"]+/);
		if (c && icons[c[0]]) {
			addIcon(el, icons[c[0]]);
		}
	}
};