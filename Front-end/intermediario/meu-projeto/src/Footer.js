import React from 'react';

export class Footer extends React.Component {
  constructor(props) {
    super(props);
    this.state = props;
  }

  render() {
    return (
      <footer>
        <p>Copyright Recode {this.state.dados.mes}-{this.state.dados.ano}</p>
      </footer>
    );
  }
}


export function Header() {
  return (
    <footer>
      <p>Header</p>
    </footer> 
  );
}

export function Left() {
  return (
    <Footer dados={ {ano: 1888, mes: 11} }/>
  );
}

export function Right() {
  return (
    <footer>
      <p>Right</p>
    </footer> 
  );
}

export function Side() {
  return (
    <footer>
      <p>Side</p>
    </footer> 
  );
}

// export default Footer;
