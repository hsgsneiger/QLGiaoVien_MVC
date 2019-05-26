
class Features {
    static isUpdate =false;
    static exportToExcel(tableID,lecturesName) {
        const dataType = 'data:application/vnd.ms-excel,%EF%BB%BF';
        let tableSelect = document.getElementById(tableID);
        if (!tableSelect) {
            alert('Dữ liệu trống!')
            return;
        }
        let dataExport = `<tr>Giáo viên: ${lecturesName.toUpperCase()}</tr><table border='2px'><tr bgcolor='#4BACC6'>${tableSelect.rows[0].innerHTML.replace(/(<th>Thao tác<\/th>)/, '')}</tr>`;
        debugger
        for (let i = 1; i < tableSelect.rows.length; i++) {
            if (tableSelect.rows[i].outerHTML.includes('bg-gray-500')) {
                dataExport += `<tr bgcolor='#DAEEF3'>${tableSelect.rows[i].innerHTML.replace(/(<td><\/td>)/, '')}</tr>`;
            } else {
                dataExport += `<tr>${tableSelect.rows[i].innerHTML.replace(/(<td><i data-toggle="modal" data-target="#exampleModal".*)/,'')}</tr>`;
            }
        }

        dataExport += "</table>";

        window.open(`${dataType}${encodeURIComponent(dataExport)}`);
    }

    static doPost(url, data, isAlert, id) {
        $.ajax({
            url: url,
            method: 'post',
            data: data
        }).done((result) => {
            if (isAlert) {
                if (result.Code === 0) {
                    $("#exampleModal").modal("hide");
                    toastr.success(result.Message);
                    setTimeout(() => {
                        Features.doPost(urlTb, {
                            "MaGV": +$("#GV").val(),
                            "MaNamHoc": +$("#Nam").val()
                        }, false, 'data-table');

                    }, 300);
                } else {
                    toastr.error(result.Message);
                }
            } else {
                $(`#${id}`).html(result);
            }
        })
    }
    static getValueFromModal() {
        let modalItems = $("#exampleModal").find("input,textarea,select.form-control");
        //Parse value to json
        let params = {};
        for (let i = 0; i < modalItems.length; i++) {
            if (modalItems[i].id != "") {
                if (modalItems[i].type == "file") {
                    continue;
                } else if (modalItems[i].type == "checkbox") {

                    params[modalItems[i].id] = modalItems[i].checked;
                    continue;
                }
                let res = this.checkValid(modalItems[i]);
                if (res.valid) {
                    params[modalItems[i].id] = modalItems[i].value.trim();
                } else {
                    toastr.error(res.message);
                    return false;
                }
            }
        }
        return params;
    }

    static checkValid(item) {
        debugger
        if (item.classList.contains('required') && item.value.trim() == '') {
            $(`#${item.id}`).focus();
            return { valid: false, message: 'Vui lòng điền đầy đủ thông tin' };
        } else if (item.classList.contains('number') && (+item.value < 0)) {
            $(`#${item.id}`).focus();
            return { valid: false, message: 'Trường số phải lớn hơn không ' };
        }
        return { valid: true };
    }
    static Delete(url, data) {
        if (confirm('Bạn có chắc chắn muốn xóa')) {
            Features.doPost(url, data, true);
        }
    }
    
}