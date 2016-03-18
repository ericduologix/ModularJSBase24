Box.Application.addService('ajax', function (context) {

	return {
		init: function () {
			$.ajaxSetup({
				type: "GET",
				dataType: "json",
				ifModified: true,
				cache: true
			});
		},
		get: function (URL, callback) {
			$.ajax({
				url: URL,
				success: function (data) {
					callback(JSON.parse(data));

				}
			});
		}
	};
});