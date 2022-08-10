// 杂项 API
import { api } from '../boot/axios';

const csList = () => {
    return api.get('https://csl.littleservice.cn/detail.json').then(res => res.data)
}

export { csList }
