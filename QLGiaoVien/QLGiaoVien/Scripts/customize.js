class Features {
    static exportToExcel(tableID,lecaturesName) {
        const dataType = 'data:application/vnd.ms-excel,';
        let tableSelect = document.getElementById(tableID);

        let dataExport = `<tr>Giáo viên: ${lecaturesName.toUpperCase()}</tr><table border='2px'><tr bgcolor='#4BACC6'>${tableSelect.rows[0].innerHTML}</tr>`;
        for (let i = 1; i < tableSelect.rows.length; i++) {
            if (tableSelect.rows[i].outerHTML.includes('bg-gray-500')) {
                dataExport += `<tr bgcolor='#DAEEF3'>${tableSelect.rows[i].innerHTML}</tr>`;
            } else {
                dataExport += `<tr>${tableSelect.rows[i].innerHTML}</tr>`;
            }

        }

        dataExport += "</table>";


        window.open(`${dataType}${encodeURIComponent(dataExport)}`);
        
        
    }
    
}