test('Validar as principais operações do JEST', () => {
    let number = null;
    expect(number).toBeNull();
    number = 10;
    expect(number).not.toBeNull();
    expect(number).toBe(10);
    expect(number).toEqual(10);
    expect(number).toBeGreaterThan(9);
    expect(number).toBeLessThan(11);

});

test('Validar operações com objetos', () => {
    const obj = {
        name: 'Tiago Vieira',
        mail: 'a20736@alunos.ipca.pt'
    };
    expect(obj).toHaveProperty('name');
    expect(obj).toHaveProperty('name', 'Tiago Vieira');
    expect(obj.name).toBe('Tiago Vieira');

    const obj2 = {
        name: 'Tiago Vieira',
        mail: 'a20736@alunos.ipca.pt'
    };
    expect(obj).toEqual(obj2);
});