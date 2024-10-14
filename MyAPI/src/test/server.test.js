const supertest = requiere('supertest');
const request = supertest('http://localhost:3001');
test('Validar se o servidor responde no porto 3001', () => {
    return request.get('/')
        .then((res) => expect(res.status).toBe(200));
});