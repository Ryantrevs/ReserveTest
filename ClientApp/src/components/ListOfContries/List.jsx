import React,{useState, useEffect} from 'react'
import {Background, Container, ListItem} from './Elements'

export function List() {
    const [listState, setList] = useState([])

    useEffect(() => {
        let clean = false
        consumer();
        return () => {
            clean= true
        }
    }, [input])

    async function Consumer(){
        var response = await fetch("API/getList");
        setList(response.data);
    }
    return (
        <Background>
            <Container>
                listState.map((index,item)=>(
                    <ListItem>
                        <h5>{index}</h5>
                        <h5>{item.Name}</h5>
                        <h5>{item.ActiveCases}</h5>
                    </ListItem>
                ))
                
            </Container>
        </Background>
    )
}
