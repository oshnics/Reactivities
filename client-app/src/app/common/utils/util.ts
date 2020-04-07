export const combineDateAndTime = (date: Date, time: Date) => {
    const strTime = time.getHours() + ':' + time.getMinutes() + ':00';

    const year  = date.getFullYear();
    const month = date.getMonth() + 1;
    const day   = date.getDate();

    const strDate = `${year}-${month}-${day}`;

    return new Date(strDate + ' ' + strTime);
}